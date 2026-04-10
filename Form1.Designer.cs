namespace BurgerKiosk
{
    partial class FMBurgerOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMBurgerOrder));
            lblTitle = new Label();
            gbMainMenu = new GroupBox();
            rdoBulgogiburger = new RadioButton();
            rdoChikenBurger = new RadioButton();
            rdoCheeseBurger = new RadioButton();
            pictureBox1 = new PictureBox();
            lblMenu = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            gbSideMenu = new GroupBox();
            ckSide4 = new CheckBox();
            ckSide3 = new CheckBox();
            ckSide2 = new CheckBox();
            ckSide1 = new CheckBox();
            lblSide = new Label();
            gbCalculate = new GroupBox();
            lblTotalCost = new Label();
            lstTotalCost = new ListBox();
            lblBill = new Label();
            btnOrder = new Button();
            btnClear = new Button();
            gbMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            gbSideMenu.SuspendLayout();
            gbCalculate.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(434, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(890, 128);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "버거 주문 키오스크";
            // 
            // gbMainMenu
            // 
            gbMainMenu.Controls.Add(rdoBulgogiburger);
            gbMainMenu.Controls.Add(rdoChikenBurger);
            gbMainMenu.Controls.Add(rdoCheeseBurger);
            gbMainMenu.Controls.Add(pictureBox1);
            gbMainMenu.Controls.Add(lblMenu);
            gbMainMenu.Controls.Add(pictureBox3);
            gbMainMenu.Controls.Add(pictureBox2);
            gbMainMenu.Location = new Point(40, 182);
            gbMainMenu.Name = "gbMainMenu";
            gbMainMenu.Size = new Size(522, 704);
            gbMainMenu.TabIndex = 0;
            gbMainMenu.TabStop = false;
            gbMainMenu.Enter += groupBox1_Enter;
            // 
            // rdoBulgogiburger
            // 
            rdoBulgogiburger.AutoSize = true;
            rdoBulgogiburger.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoBulgogiburger.Location = new Point(18, 535);
            rdoBulgogiburger.Name = "rdoBulgogiburger";
            rdoBulgogiburger.Size = new Size(316, 69);
            rdoBulgogiburger.TabIndex = 17;
            rdoBulgogiburger.Text = "불고기 버거";
            rdoBulgogiburger.UseVisualStyleBackColor = true;
            rdoBulgogiburger.CheckedChanged += radioButton_CheckedChanged;
            // 
            // rdoChikenBurger
            // 
            rdoChikenBurger.AutoSize = true;
            rdoChikenBurger.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoChikenBurger.Location = new Point(18, 338);
            rdoChikenBurger.Name = "rdoChikenBurger";
            rdoChikenBurger.Size = new Size(268, 69);
            rdoChikenBurger.TabIndex = 16;
            rdoChikenBurger.Text = "치킨 버거";
            rdoChikenBurger.UseVisualStyleBackColor = true;
            rdoChikenBurger.CheckedChanged += radioButton_CheckedChanged;
            // 
            // rdoCheeseBurger
            // 
            rdoCheeseBurger.AutoSize = true;
            rdoCheeseBurger.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoCheeseBurger.Location = new Point(18, 157);
            rdoCheeseBurger.Name = "rdoCheeseBurger";
            rdoCheeseBurger.Size = new Size(268, 69);
            rdoCheeseBurger.TabIndex = 15;
            rdoCheeseBurger.Text = "치즈 버거";
            rdoCheeseBurger.UseVisualStyleBackColor = true;
            rdoCheeseBurger.CheckedChanged += radioButton_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(359, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblMenu.ForeColor = Color.Red;
            lblMenu.Location = new Point(-2, 37);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(237, 65);
            lblMenu.TabIndex = 14;
            lblMenu.Text = "메뉴 선택";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(351, 502);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(165, 132);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(359, 304);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(160, 146);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // gbSideMenu
            // 
            gbSideMenu.Controls.Add(ckSide4);
            gbSideMenu.Controls.Add(ckSide3);
            gbSideMenu.Controls.Add(ckSide2);
            gbSideMenu.Controls.Add(ckSide1);
            gbSideMenu.Controls.Add(lblSide);
            gbSideMenu.Location = new Point(643, 182);
            gbSideMenu.Name = "gbSideMenu";
            gbSideMenu.Size = new Size(357, 553);
            gbSideMenu.TabIndex = 1;
            gbSideMenu.TabStop = false;
            // 
            // ckSide4
            // 
            ckSide4.AutoSize = true;
            ckSide4.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            ckSide4.Location = new Point(53, 401);
            ckSide4.Name = "ckSide4";
            ckSide4.Size = new Size(269, 69);
            ckSide4.TabIndex = 17;
            ckSide4.Text = "소스 추가";
            ckSide4.UseVisualStyleBackColor = true;
            ckSide4.CheckedChanged += checkBox_CheckedChanged;
            // 
            // ckSide3
            // 
            ckSide3.AutoSize = true;
            ckSide3.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            ckSide3.Location = new Point(53, 316);
            ckSide3.Name = "ckSide3";
            ckSide3.Size = new Size(269, 69);
            ckSide3.TabIndex = 16;
            ckSide3.Text = "치즈 추가";
            ckSide3.UseVisualStyleBackColor = true;
            ckSide3.CheckedChanged += checkBox_CheckedChanged;
            // 
            // ckSide2
            // 
            ckSide2.AutoSize = true;
            ckSide2.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            ckSide2.Location = new Point(53, 231);
            ckSide2.Name = "ckSide2";
            ckSide2.Size = new Size(156, 69);
            ckSide2.TabIndex = 15;
            ckSide2.Text = "콜라";
            ckSide2.UseVisualStyleBackColor = true;
            ckSide2.CheckedChanged += checkBox_CheckedChanged;
            // 
            // ckSide1
            // 
            ckSide1.AutoSize = true;
            ckSide1.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            ckSide1.Location = new Point(53, 142);
            ckSide1.Name = "ckSide1";
            ckSide1.Size = new Size(252, 69);
            ckSide1.TabIndex = 14;
            ckSide1.Text = "감자튀김";
            ckSide1.UseVisualStyleBackColor = true;
            ckSide1.CheckedChanged += checkBox_CheckedChanged;
            // 
            // lblSide
            // 
            lblSide.AutoSize = true;
            lblSide.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblSide.ForeColor = Color.Red;
            lblSide.Location = new Point(53, 37);
            lblSide.Name = "lblSide";
            lblSide.Size = new Size(237, 65);
            lblSide.TabIndex = 13;
            lblSide.Text = "메뉴 선택";
            // 
            // gbCalculate
            // 
            gbCalculate.Controls.Add(lblTotalCost);
            gbCalculate.Controls.Add(lstTotalCost);
            gbCalculate.Controls.Add(lblBill);
            gbCalculate.Location = new Point(1135, 182);
            gbCalculate.Name = "gbCalculate";
            gbCalculate.Size = new Size(582, 553);
            gbCalculate.TabIndex = 17;
            gbCalculate.TabStop = false;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(53, 477);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(178, 59);
            lblTotalCost.TabIndex = 17;
            lblTotalCost.Text = "총 금액:";
            // 
            // lstTotalCost
            // 
            lstTotalCost.FormattingEnabled = true;
            lstTotalCost.Location = new Point(53, 126);
            lstTotalCost.Name = "lstTotalCost";
            lstTotalCost.Size = new Size(453, 324);
            lstTotalCost.TabIndex = 16;
            // 
            // lblBill
            // 
            lblBill.AutoSize = true;
            lblBill.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblBill.ForeColor = Color.Red;
            lblBill.Location = new Point(53, 37);
            lblBill.Name = "lblBill";
            lblBill.Size = new Size(237, 65);
            lblBill.TabIndex = 15;
            lblBill.Text = "주문 내역";
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Lime;
            btnOrder.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = SystemColors.ButtonHighlight;
            btnOrder.Location = new Point(1188, 766);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(219, 84);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(1440, 766);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(219, 84);
            btnClear.TabIndex = 19;
            btnClear.Text = "처음으로";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // FMBurgerOrder
            // 
            AcceptButton = btnOrder;
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1777, 956);
            Controls.Add(btnClear);
            Controls.Add(gbCalculate);
            Controls.Add(btnOrder);
            Controls.Add(gbSideMenu);
            Controls.Add(gbMainMenu);
            Controls.Add(lblTitle);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FMBurgerOrder";
            Text = "Burger Kiosk";
            gbMainMenu.ResumeLayout(false);
            gbMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            gbSideMenu.ResumeLayout(false);
            gbSideMenu.PerformLayout();
            gbCalculate.ResumeLayout(false);
            gbCalculate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox gbMainMenu;
        private PictureBox pictureBox1;
        private Label lblMenu;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private CheckBox CKBurger2;
        private CheckBox CKBurger3;
        private CheckBox CKBurger1;
        private GroupBox gbSideMenu;
        private CheckBox ckSide4;
        private CheckBox ckSide3;
        private CheckBox ckSide2;
        private CheckBox ckSide1;
        private Label lblSide;
        private GroupBox gbCalculate;
        private ListBox lstTotalCost;
        private Label lblBill;
        private RadioButton rdoCheeseBurger;
        private Label lblTotalCost;
        private RadioButton rdoBulgogiburger;
        private RadioButton rdoChikenBurger;
        private Button button2;
        private Button btnOrder;
        private Button btnClear;
    }
}
