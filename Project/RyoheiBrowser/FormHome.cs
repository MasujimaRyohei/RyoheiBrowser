using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace RyoheiBrowser
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

            // ●お気に入りの復元 XML -> Object
            XmlSerializer serializer = new XmlSerializer(typeof(List<FavoriteData>));
            List<FavoriteData> favoriteDataList = null;
            using (System.IO.StreamReader reader = new System.IO.StreamReader("favorite.xml", Encoding.UTF8))
            {
                // XML -> OBJECT
                favoriteDataList = (List<FavoriteData>)serializer.Deserialize(reader);
            }

            // ●リストに追加する
            for (int i = 0; i < favoriteDataList.Count; i++)
            {
                lstFavorite.Items.Add(favoriteDataList[i]);
            }

            browser.Url = new Uri("http://MasujimaRyohei.jp");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://MasujimaRyohei.jp");
        }


        // ●戻る
        private void btnBack_Click(object sender, EventArgs e)
        {
            browser.GoBack();
        }

        // ●進む
        private void btnNext_Click(object sender, EventArgs e)
        {
            browser.GoForward();
        }

        // ●ページ移動したあとのイベント
        private void browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtUrl.Text = browser.Url.ToString();

            btnBack.Enabled = browser.CanGoBack;
            btnNext.Enabled = browser.CanGoForward;
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                // ●Enterが押されたら
                browser.Url = new Uri(txtUrl.Text);
            }
        }

        // ●更新
        private void btnReload_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri(txtUrl.Text);
        }


        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            // お気に入り -> XML

            // text
            List<FavoriteData> favoriteDataList = new List<FavoriteData>();

            for (int i = 0; i < lstFavorite.Items.Count; i++)
            {
                favoriteDataList.Add((FavoriteData)lstFavorite.Items[i]);
            }

            // ●お気に入りデータの設定
            {
                FavoriteData data = new FavoriteData();
                data.Title = browser.DocumentTitle;
                data.Url = browser.Url.ToString();
            }

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<FavoriteData>));
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("favorite.xml", false, Encoding.UTF8))
            {
                serializer.Serialize(writer, favoriteDataList);
            }
        }

        public class FavoriteData
        {
            public String Title = "";
            public String Url = "";

            public override string ToString()
            {
                return Title;
            }
        }

        private void favoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFavorite formFavorite = new FormFavorite();
            formFavorite.Show();
        }

        private void pnlFavorite_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblFavorite_Click(object sender, EventArgs e)
        {

        }

        private void lstFavorite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
