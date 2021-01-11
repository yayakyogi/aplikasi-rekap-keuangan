/*
 * Created by SharpDevelop.
 * User: PCKURO
 * Date: 24/04/2020
 * Time: 3:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aplikasi_RekapKeuangan
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		float jumlah;
		float saldoAkhir=1000000;
		int indexRow;
		String sta="";
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			dataGridView1.Columns.Add("tgl","Tanggal");
			dataGridView1.Columns.Add("nominal","Nominal");
			dataGridView1.Columns.Add("keperluan","Keperluan");
			dataGridView1.Columns.Add("status","Status");
			textBoxSaldo.Text="Rp "+saldoAkhir.ToString("N");
		}
		
		// Button Save
		void Button1Click(object sender, EventArgs e)
		{
			
			if(checkBox1Peng.Checked) sta="Pengeluaran";
			else if(checkBoxPem.Checked) sta="Pemasukan";
			
			String[] tanggal={textBoxTgl.Text};
			String[] nominal={textBoxNom.Text};
			String[] keperluan={textBoxKep.Text};
			String[] status={sta};
			jumlah=float.Parse(textBoxNom.Text);
			
			for(int i=0; i<tanggal.Length; i++){
				dataGridView1.Rows.Add(new object[]{tanggal[i],nominal[i],keperluan[i],status[i]});
			}
			
			if(checkBox1Peng.Checked){
				saldoAkhir-=jumlah;
				textBoxSaldo.Text="Rp "+saldoAkhir.ToString("N");
			}
			if(checkBoxPem.Checked){
				saldoAkhir+=jumlah;
				textBoxSaldo.Text="Rp "+saldoAkhir.ToString("N");
			}
			
			textBoxKep.Clear();
			textBoxNom.Clear();
			textBoxTgl.Clear();
			jumlah=0;
		}
	
		// Fungsi untuk menampilkan edit
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			indexRow = e.RowIndex;
			DataGridViewRow row = dataGridView1.Rows[indexRow];
			
			textBoxTgl.Text=row.Cells[0].Value.ToString();
			textBoxNom.Text=row.Cells[1].Value.ToString();
			textBoxKep.Text=row.Cells[2].Value.ToString();
			buttonSave.Enabled=false;
			
		}
		// Button Edit
		void ButtonEditClick(object sender, EventArgs e)
		{	
			DataGridViewRow newrow = dataGridView1.Rows[indexRow];
			newrow.Cells[0].Value=textBoxTgl.Text;
			newrow.Cells[1].Value=textBoxNom.Text;
			newrow.Cells[2].Value=textBoxKep.Text;
			jumlah=float.Parse(textBoxNom.Text);
			if(checkBox1Peng.Checked){
				sta="Pengeluaran";
				saldoAkhir-=jumlah;
				textBoxSaldo.Text="Rp "+saldoAkhir.ToString("N");
			}
			else if(checkBoxPem.Checked){
				sta="Pemasukan";
				saldoAkhir+=jumlah;
				textBoxSaldo.Text="Rp "+saldoAkhir.ToString("N");
			}
			newrow.Cells[3].Value=sta;
			buttonSave.Enabled=true;
			textBoxKep.Clear();
			textBoxNom.Clear();
			textBoxTgl.Clear();
			jumlah=0;
		}
		
		// Button Delete
		void ButtonDelClick(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Anda yakin ingin menghapus riwayat ini?","Warning",MessageBoxButtons.YesNo);
			if(result==DialogResult.Yes){
				indexRow=dataGridView1.CurrentCell.RowIndex;
				dataGridView1.Rows.RemoveAt(indexRow);
			}
		}
	}
}
