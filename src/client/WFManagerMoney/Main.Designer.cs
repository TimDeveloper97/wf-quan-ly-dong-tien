namespace WFManagerMoney
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnInstallmentPayment = new Button();
            btnPawnShop = new Button();
            groupBox2 = new GroupBox();
            groupBox5 = new GroupBox();
            lbHaveMoney = new Label();
            label4 = new Label();
            groupBox4 = new GroupBox();
            lbGiveMoney = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnExport = new Button();
            btnAdd = new Button();
            dgvItems = new DataGridView();
            groupBox6 = new GroupBox();
            lbNumberContractDuedate = new Label();
            label3 = new Label();
            groupBox7 = new GroupBox();
            lbNumberContractOutdate = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnInstallmentPayment);
            groupBox1.Controls.Add(btnPawnShop);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(150, 120);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // btnInstallmentPayment
            // 
            btnInstallmentPayment.Location = new Point(6, 56);
            btnInstallmentPayment.Name = "btnInstallmentPayment";
            btnInstallmentPayment.Size = new Size(138, 28);
            btnInstallmentPayment.TabIndex = 1;
            btnInstallmentPayment.Text = "Trả Góp";
            btnInstallmentPayment.UseVisualStyleBackColor = true;
            // 
            // btnPawnShop
            // 
            btnPawnShop.Location = new Point(6, 22);
            btnPawnShop.Name = "btnPawnShop";
            btnPawnShop.Size = new Size(138, 28);
            btnPawnShop.TabIndex = 0;
            btnPawnShop.Text = "Cầm Đồ";
            btnPawnShop.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox7);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Location = new Point(168, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(865, 130);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dashboard";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lbHaveMoney);
            groupBox5.Controls.Add(label4);
            groupBox5.Location = new Point(212, 20);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(200, 100);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            // 
            // lbHaveMoney
            // 
            lbHaveMoney.AutoSize = true;
            lbHaveMoney.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHaveMoney.Location = new Point(16, 47);
            lbHaveMoney.Name = "lbHaveMoney";
            lbHaveMoney.Size = new Size(149, 32);
            lbHaveMoney.TabIndex = 1;
            lbHaveMoney.Text = "100000000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 19);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 0;
            label4.Text = "Tổng tiền đã nhận";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbGiveMoney);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(6, 20);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 100);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // lbGiveMoney
            // 
            lbGiveMoney.AutoSize = true;
            lbGiveMoney.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGiveMoney.Location = new Point(16, 47);
            lbGiveMoney.Name = "lbGiveMoney";
            lbGiveMoney.Size = new Size(149, 32);
            lbGiveMoney.TabIndex = 1;
            lbGiveMoney.Text = "100000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Tổng tiền đưa khách";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnExport);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Controls.Add(dgvItems);
            groupBox3.Location = new Point(168, 142);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(865, 511);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Items";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(784, 22);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 2;
            btnExport.Text = "Xuất Excel";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(703, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(6, 55);
            dgvItems.Name = "dgvItems";
            dgvItems.Size = new Size(853, 450);
            dgvItems.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lbNumberContractDuedate);
            groupBox6.Controls.Add(label3);
            groupBox6.Location = new Point(453, 20);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(200, 100);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            // 
            // lbNumberContractDuedate
            // 
            lbNumberContractDuedate.AutoSize = true;
            lbNumberContractDuedate.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNumberContractDuedate.Location = new Point(16, 47);
            lbNumberContractDuedate.Name = "lbNumberContractDuedate";
            lbNumberContractDuedate.Size = new Size(82, 32);
            lbNumberContractDuedate.TabIndex = 1;
            lbNumberContractDuedate.Text = "10/20";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 19);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 0;
            label3.Text = "Số hợp đồng đến hạn";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(lbNumberContractOutdate);
            groupBox7.Controls.Add(label6);
            groupBox7.Location = new Point(659, 20);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(200, 100);
            groupBox7.TabIndex = 5;
            groupBox7.TabStop = false;
            // 
            // lbNumberContractOutdate
            // 
            lbNumberContractOutdate.AutoSize = true;
            lbNumberContractOutdate.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNumberContractOutdate.Location = new Point(16, 47);
            lbNumberContractOutdate.Name = "lbNumberContractOutdate";
            lbNumberContractOutdate.Size = new Size(67, 32);
            lbNumberContractOutdate.TabIndex = 1;
            lbNumberContractOutdate.Text = "2/20";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 19);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 0;
            label6.Text = "Số hợp đồng quá hạn";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 665);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Main";
            Text = "Main";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnInstallmentPayment;
        private Button btnPawnShop;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnExport;
        private Button btnAdd;
        private DataGridView dgvItems;
        private Label lbGiveMoney;
        private Label label1;
        private GroupBox groupBox5;
        private Label lbHaveMoney;
        private Label label4;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private Label lbNumberContractDuedate;
        private Label label3;
        private GroupBox groupBox7;
        private Label lbNumberContractOutdate;
        private Label label6;
        //private SplitContainer splitContainer1;
    }
}
