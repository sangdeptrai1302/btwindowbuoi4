using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            String song = lbSong.SelectedItem.ToString();
            lbFavorite.Items.Add(song);
            lbSong.Items.RemoveAt(lbSong.SelectedIndex);
        }

        private void btSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbSong.Items.Count; i++)
            {
                String song = lbSong.Items[i].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(i);
            }
        }

        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbSong.IndexFromPoint(e.Location);
            if(index != System.Windows.Forms.ListBox.NoMatches)
            {
                String song = lbSong.Items[index].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(lbSong.SelectedIndex);
            }
        }

        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbFavorite.Items.Count; i++)
            {
                String desong = lbFavorite.Items[i].ToString();
                lbSong.Items.Add(desong);
                lbFavorite.Items.RemoveAt(i);
            }
        }

        private void btDeselect_Click(object sender, EventArgs e)
        {
            String desong = lbFavorite.SelectedItem.ToString();
            lbSong.Items.Add(desong);
            lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
        }
    }
}
