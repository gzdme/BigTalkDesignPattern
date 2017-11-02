using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 策略模式
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        double total = 0.0;
        public MainWindow()
        {
            InitializeComponent();
            cbxType.Items.Add("正常收费");
            cbxType.Items.Add("满300返100");
            cbxType.Items.Add("打八折");
            //cbxType.Items.Add("打七折");
            //cbxType.Items.Add("打五折");
            cbxType.SelectedIndex = 0;
        }

        #region 过程式实现
        //private void btnOK_Click(object sender, RoutedEventArgs e)
        //{
        //    double totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);
        //    total += totalPrices;

        //    lbxList.Items.Add("单价： " + txtPrice.Text + "数量： " + txtNum.Text + "，合计： " + totalPrices.ToString());
        //    lblResult.Text = total.ToString();
        //}
        #endregion

        #region 增加打折和返利
        //private void btnOK_Click(object sender, RoutedEventArgs e)
        //{
        //    double totalPrices = 0;
        //    switch (cbxType.SelectedIndex)
        //    {
        //        case 0:
        //            totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);
        //            break;
        //        case 1:
        //            totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.8;
        //            break;
        //        case 2:
        //            totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.7;
        //            break;
        //        case 3:
        //            totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.6;
        //            break;
        //        default:
        //            break;
        //    }
        //    total += totalPrices;

        //    lbxList.Items.Add("单价： " + txtPrice.Text + "数量： " + txtNum.Text + "，合计： " + totalPrices.ToString());
        //    lblResult.Text = total.ToString();
        //}
        #endregion


        #region 简单工厂模式
        //private void btnOK_Click(object sender, RoutedEventArgs e)
        //{
        //    CashSuper csuper = CashFactory.createCashAccept(cbxType.SelectedItem.ToString());
        //    double totalPrices = 0d;
        //    totalPrices = csuper.acceptCash(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text));
        //    total += totalPrices;

        //    lbxList.Items.Add("单价： " + txtPrice.Text + "数量： " + txtNum.Text + "，合计： " + totalPrices.ToString());
        //    lblResult.Text = total.ToString();
        //}
        #endregion

        #region 策略模式
        //private void btnOK_Click(object sender, RoutedEventArgs e)
        //{
        //    CashContext cashContext = null;
        //    switch (cbxType.SelectedItem.ToString())
        //    {
        //        case "正常收费":
        //            cashContext = new CashContext(new CashNormal());
        //            break;
        //        case "满300返100":
        //            cashContext = new CashContext(new CashReturn("300", "100"));
        //            break;
        //        case "打8折":
        //            cashContext = new CashContext(new CashRebate("0.8"));
        //            break;
        //        default:
        //            break;
        //    }

        //    double totalPrices = 0d;
        //    totalPrices = cashContext.GetResult(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text));
        //    total += totalPrices;

        //    lbxList.Items.Add("单价： " + txtPrice.Text + "数量： " + txtNum.Text + "，合计： " + totalPrices.ToString());
        //    lblResult.Text = total.ToString();
        //}
        #endregion

        #region 策略结合简单工厂模式
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            CashContext cashContext = new CashContext(cbxType.SelectedItem.ToString());
            double totalPrices = 0d;
            totalPrices = cashContext.GetResult(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text));
            total += totalPrices;

            lbxList.Items.Add("单价： " + txtPrice.Text + "数量： " + txtNum.Text + "，合计： " + totalPrices.ToString());
            lblResult.Text = total.ToString();
        }
        #endregion

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            total = 0.0;
            txtPrice.Text = "0.0";
            txtNum.Text = "0";
            lbxList.Items.Clear();
            lblResult.Text = "0.00";
        }
    }
}
