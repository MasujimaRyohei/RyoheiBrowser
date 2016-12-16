using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyoheiBrowser
{
    public partial class FormFavorite : Form
    {
        public FormFavorite()
        {
            InitializeComponent();
        }

        private void FormFavorite_Load(object sender, EventArgs e)
        {

        }


        private void btnAddFavorite_Click(object sender, EventArgs e)
        {

        }

        private void lstFavorite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //             // ●お気に入りのダブルクリックイベント
        //       private void lstFavorite_DoubleClick(object sender, EventArgs e)
        //       {
        //           FavoriteData data = (FavoriteData)lstFavorite.Items[lstFavorite.SelectedIndex];
        //           browser.Url = new Uri(data.Url);
        //       }
        //
        //       // ●お気に入りの追加クリック
        //       private void btnAddFavorite_Click(object sender, EventArgs e)
        //       {
        //           // ●お気に入りデータの設定
        //           FavoriteData data = new FavoriteData();
        //           data.Title = browser.DocumentTitle;
        //           data.Url = browser.Url.ToString();
        //
        //           // ●リストにお気に入りデータを追加
        //           lstFavorite.Items.Add(data);
        //       }
        //       // ●お気に入りの削除クリック
        //       private void btnDeleteFavorite_Click(object sender, EventArgs e)
        //       {
        //           // ●lst が未選択でなければ
        //           if (lstFavorite.SelectedIndex != -1)
        //           {
        //               // ●選択されているお気に入りデータの取得
        //               FavoriteData data = (FavoriteData)lstFavorite.Items[lstFavorite.SelectedIndex];
        //
        //               // ●リストからお気に入りデータを削除
        //               lstFavorite.Items.Remove(data);
        //           }
        //
        //       }
        //
    }
}
