using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using QuanLyBanHang.Data;
using QuanLyBanHang.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        QLBHDbContext context = new QLBHDbContext();
        int id;

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;

            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();
            hd = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.DonGiaBan),
                XemChiTiet = "Xem chi tiết"
            }).ToList();

            dataGridView.DataSource = hd;
        }
        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa hóa đơn ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                HoaDon hd = context.HoaDon.Find(id);
                if (hd != null)
                {
                    var chiTietHoaDon = context.HoaDon_ChiTiet.Where(ct => ct.HoaDonID == id).ToList();
                    foreach (var ct in chiTietHoaDon)
                    {
                        context.HoaDon_ChiTiet.Remove(ct);
                    }
                    context.HoaDon.Remove(hd);
                }
                context.SaveChanges();

                frmHoaDon_Load(sender, e);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                int maHoaDon = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(maHoaDon))
                {
                    chiTiet.ShowDialog();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmHoaDon_Load(sender, e);
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "HoaDon_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table1 = new DataTable();
                    DataTable table2 = new DataTable();


                    table1.Columns.AddRange(new DataColumn[5] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("NhanVienID", typeof(int)),
                        new DataColumn("KhachHangID", typeof(int)),
                        new DataColumn("NgayLap", typeof(DateTime)),
                        new DataColumn("GhiChuHoaDon", typeof(string))
                     });

                    var hoaDon = context.HoaDon.ToList();
                    if (hoaDon != null)
                    {
                        foreach (var p in hoaDon)
                            table1.Rows.Add(p.ID, p.NhanVienID, p.KhachHangID, p.NgayLap, p.GhiChuHoaDon);
                    }

                    table2.Columns.AddRange(new DataColumn[5] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("HoaDonID", typeof(int)),
                        new DataColumn("SanPhamID", typeof(int)),
                        new DataColumn("SoLuongBan", typeof(int)),
                        new DataColumn("DonGiaBan", typeof(int)),
                     });

                    var chiTietHoaDon = context.HoaDon_ChiTiet.ToList();
                    if (chiTietHoaDon != null)
                    {
                        foreach (var p in chiTietHoaDon)
                            table2.Rows.Add(p.ID, p.HoaDonID, p.SanPhamID, p.SoLuongBan, p.DonGiaBan);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet1 = wb.Worksheets.Add(table1, "HoaDon");
                        var sheet2 = wb.Worksheets.Add(table2, "HoaDon_ChiTiet");
                        sheet1.Columns().AdjustToContents();
                        sheet2.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table1 = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet1 = workbook.Worksheet(1);
                        IXLWorksheet worksheet2 = workbook.Worksheet(2);
                        bool firstRow = true;
                        string readRange = "1:1";
                        foreach (IXLRow row in worksheet1.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên) 
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table1.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo) 
                            {
                                table1.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table1.Rows[table1.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }

                        }

                        DataTable table2 = new DataTable();
                        firstRow = true;
                        readRange = "1:1";
                        foreach (IXLRow row in worksheet2.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên) 
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table2.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo) 
                            {
                                table2.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table2.Rows[table2.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        if (table1.Rows.Count > 0 && table2.Rows.Count > 0)
                        {
                            foreach (DataRow r in table1.Rows)
                            {
                                HoaDon hd = new HoaDon();
                                hd.NhanVienID = Convert.ToInt32(r["NhanVienID"]);
                                hd.KhachHangID = Convert.ToInt32(r["KhachHangID"]);
                                hd.NgayLap = Convert.ToDateTime(r["NgayLap"].ToString());
                                hd.GhiChuHoaDon = r["GhiChuHoaDon"].ToString();
                                context.HoaDon.Add(hd);
                            }

                            foreach (DataRow r in table2.Rows)
                            {
                                HoaDon_ChiTiet cthd = new HoaDon_ChiTiet();
                                cthd.HoaDonID = Convert.ToInt32(r["HoaDonID"]);
                                cthd.SanPhamID = Convert.ToInt32(r["SanPhamID"]);
                                cthd.SoLuongBan = Convert.ToInt32(r["SoLuongBan"]);
                                cthd.DonGiaBan = Convert.ToInt32(r["DonGiaBan"]);
                                context.HoaDon_ChiTiet.Add(cthd);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table1.Rows.Count + " hóa đơn và " + table2.Rows.Count + " chi tiết hóa đơn", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmHoaDon_Load(sender, e);
                        }
                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            using (frmInHoaDon inHoaDon = new frmInHoaDon(id))
            {
                inHoaDon.ShowDialog();
            }
        }
    }
}