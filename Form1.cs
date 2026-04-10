namespace BurgerKiosk
{
    public partial class FMBurgerOrder : Form
    {
        public FMBurgerOrder()
        {
            InitializeComponent();
        }




        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Cheese burger checked changed handler (designer wired)
        }

        private void rdoChikenBurger_CheckedChanged(object sender, EventArgs e)
        {
            // Chicken burger checked changed handler (designer wired)
        }

        private void rdoBulgogiburger_CheckedChanged(object sender, EventArgs e)
        {
            // Bulgogi burger checked changed handler (designer wired)
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked)
            {
                UpdateMenu();
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMenu();
        }

        private void UpdateMenu()
        {
            lstTotalCost.Items.Clear();
            int totalCost = 0;


            if (rdoCheeseBurger.Checked)
            {

                lstTotalCost.Items.Add("치즈버거 :" + 5000.ToString("N0") + "원");
                totalCost += 5000;
            }
            else if (rdoChikenBurger.Checked)
            {
                lstTotalCost.Items.Add("치킨버거 :" + 4000.ToString("N0") + "원");
                totalCost += 4000;
            }
            else if (rdoBulgogiburger.Checked)
            {
                lstTotalCost.Items.Add("불고기버거 :" + 3000.ToString("N0") + "원");
                totalCost += 3000;
            }

            if (ckSide1.Checked)
            {

                lstTotalCost.Items.Add("감자튀김 :" + 3500.ToString("N0") + "원");


            }
            if (ckSide2.Checked)
            {
                lstTotalCost.Items.Add("콜라 :" + 2500.ToString("N0") + "원");
            }
            if (ckSide3.Checked)
            {
                lstTotalCost.Items.Add("치즈추가 :" + 1500.ToString("N0") + "원");
            }
            if (ckSide4.Checked)
            {
                lstTotalCost.Items.Add("소스추가 :" + 500.ToString("N0") + "원");
            }





        }
        private void button2_Click(object sender, EventArgs e)
        {
            // This method is currently empty and can be implemented later.
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            bool hasBurger = rdoCheeseBurger.Checked || rdoChikenBurger.Checked || rdoBulgogiburger.Checked;
            bool hasSide = ckSide1.Checked || ckSide2.Checked || ckSide3.Checked || ckSide4.Checked;

            if (!hasBurger && !hasSide)
            {
                lblTotalCost.Text = "메뉴가 없습니다.";
                return;
            }

           UpdateMenu();
            int totalCost = 0;

            if (rdoCheeseBurger.Checked)
            {
                totalCost = 5000;

            }
            else if (rdoChikenBurger.Checked)
            {
                totalCost = 4000;

            }
            else if (rdoBulgogiburger.Checked)
            {
                totalCost = 3000;

            }

            if (ckSide1.Checked)
            {
                totalCost += 3500;
            }
            if (ckSide2.Checked)
            {
                totalCost += 2500;
            }
            if (ckSide3.Checked)
            {
                totalCost += 1500;
            }
            if (ckSide4.Checked)
            {
                totalCost += 500;
            }

           

            lblTotalCost.Text = "총 금액:" + totalCost.ToString("N0") + "원";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           rdoCheeseBurger.Checked = false;
            rdoChikenBurger.Checked = false;
            rdoBulgogiburger.Checked = false;

            // 🍟 체크박스 초기화
            ckSide1.Checked = false;
            ckSide2.Checked = false;
            ckSide3.Checked = false;
            ckSide4.Checked = false;

            // 📋 리스트박스 초기화
            lstTotalCost.Items.Clear();
            lblTotalCost.Text = "총 금액: 0원";
        }
    }
}
