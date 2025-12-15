using BrothersBlog.Models.Models;
using WFManagerMoney.CRUD;
using WFManagerMoney.Model;

namespace WFManagerMoney
{
    public partial class Main : Form
    {
        private readonly List<PageData> _menuPages = new();
        private PageData _currentPage;

        public Main()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            InitButton();
            InitDataGridView();
        }

        private void InitButton()
        {
            // Đăng ký các nút menu vào danh sách để dễ quản lý
            _menuPages.Add(new PageData { Model = typeof(ContractPawnShop), Action = btnPawnShop });
            _menuPages.Add(new PageData { Model = typeof(ContractInstallmentPayment), Action = btnInstallmentPayment });

            // Gán sự kiện click cho các nút menu
            btnPawnShop.Click += MenuButton_Click;
            btnInstallmentPayment.Click += MenuButton_Click;

            // Thiết lập nút mặc định khi khởi động
            this.MenuButton_Click(btnPawnShop, null);
        }

        private void InitDataGridView()
        {
            // Cấu hình các cột cho dgvItems
            dgvItems.Columns.Clear();
            dgvItems.AutoGenerateColumns = false;

            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CustomerName",
                HeaderText = "Tên khách hàng",
                DataPropertyName = "CustomerName"
            });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "InstallmentAmount",
                HeaderText = "Tiền trả góp",
                DataPropertyName = "InstallmentAmount"
            });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DueDate",
                HeaderText = "Thời gian đến hạn",
                DataPropertyName = "DueDate"
            });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LoanDate",
                HeaderText = "Ngày vay",
                DataPropertyName = "LoanDate"
            });
        }

        private void MenuButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                SetActiveMenuButton(clickedButton);

                // Cập nhật _currentPage theo button vừa click
                _currentPage = _menuPages.FirstOrDefault(p => p.Action == clickedButton);

                // TODO: Xử lý logic hiển thị dữ liệu tương ứng với menu
                if (clickedButton == btnPawnShop)
                {
                    // Hiển thị dữ liệu hợp đồng cầm đồ
                    InitStatePawnShop();
                }
                else if (clickedButton == btnInstallmentPayment)
                {
                    // Hiển thị dữ liệu hợp đồng trả góp
                    InitStateInstallmentPayment();
                }
            }
        }

        private void InitStateInstallmentPayment()
        {
            this.lbGiveMoney.Text = Format.SetGiveMoney(0);
            this.lbHaveMoney.Text = Format.SetGiveMoney(0);
            this.lbNumberContractDuedate.Text = Format.SetNumberContractDuedate(0, 10);
            this.lbNumberContractOutdate.Text = Format.SetNumberContractDuedate(0, 10);
        }

        private void InitStatePawnShop()
        {
            this.lbGiveMoney.Text = Format.SetGiveMoney(1);
            this.lbHaveMoney.Text = Format.SetGiveMoney(1);
            this.lbNumberContractDuedate.Text = Format.SetNumberContractDuedate(2, 10);
            this.lbNumberContractOutdate.Text = Format.SetNumberContractDuedate(2, 10);
        }

        private void SetActiveMenuButton(Button activeButton)
        {
            foreach (var page in _menuPages)
            {
                var btn = page.Action;

                btn.BackColor = SystemColors.Control;
                btn.ForeColor = SystemColors.ControlText;
                btn.Font = new Font(btn.Font, FontStyle.Regular);
            }

            activeButton.BackColor = Color.DodgerBlue;
            activeButton.ForeColor = Color.White;
            activeButton.Font = new Font(activeButton.Font, FontStyle.Bold);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var form = new AddForm(this._currentPage.Model);
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Sau khi lưu, có thể reload lại danh sách hoặc cập nhật dgvItems
            }
        }
    }
}
