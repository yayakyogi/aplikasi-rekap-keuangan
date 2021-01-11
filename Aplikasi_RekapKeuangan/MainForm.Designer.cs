/*
 * Created by SharpDevelop.
 * User: PCKURO
 * Date: 24/04/2020
 * Time: 3:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Aplikasi_RekapKeuangan
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBoxSaldo;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBoxPem;
		private System.Windows.Forms.CheckBox checkBox1Peng;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxTgl;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.TextBox textBoxNom;
		private System.Windows.Forms.TextBox textBoxKep;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonDel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonEdit;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxSaldo = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBoxPem = new System.Windows.Forms.CheckBox();
			this.checkBox1Peng = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxTgl = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.textBoxNom = new System.Windows.Forms.TextBox();
			this.textBoxKep = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonDel = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxSaldo);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(23, 20);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(185, 54);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "SALDO";
			// 
			// textBoxSaldo
			// 
			this.textBoxSaldo.Location = new System.Drawing.Point(19, 20);
			this.textBoxSaldo.Name = "textBoxSaldo";
			this.textBoxSaldo.Size = new System.Drawing.Size(148, 20);
			this.textBoxSaldo.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBoxPem);
			this.groupBox2.Controls.Add(this.checkBox1Peng);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.textBoxTgl);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.buttonSave);
			this.groupBox2.Controls.Add(this.textBoxNom);
			this.groupBox2.Controls.Add(this.textBoxKep);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(23, 94);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(305, 242);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Data Keuangan";
			// 
			// checkBoxPem
			// 
			this.checkBoxPem.Location = new System.Drawing.Point(95, 175);
			this.checkBoxPem.Name = "checkBoxPem";
			this.checkBoxPem.Size = new System.Drawing.Size(104, 24);
			this.checkBoxPem.TabIndex = 9;
			this.checkBoxPem.Text = "Pemasukan";
			this.checkBoxPem.UseVisualStyleBackColor = true;
			// 
			// checkBox1Peng
			// 
			this.checkBox1Peng.Location = new System.Drawing.Point(95, 150);
			this.checkBox1Peng.Name = "checkBox1Peng";
			this.checkBox1Peng.Size = new System.Drawing.Size(104, 24);
			this.checkBox1Peng.TabIndex = 8;
			this.checkBox1Peng.Text = "Pengeluaran";
			this.checkBox1Peng.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(95, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(179, 19);
			this.label4.TabIndex = 7;
			this.label4.Text = "dd/mm/yyyy";
			// 
			// textBoxTgl
			// 
			this.textBoxTgl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTgl.Location = new System.Drawing.Point(95, 35);
			this.textBoxTgl.Name = "textBoxTgl";
			this.textBoxTgl.Size = new System.Drawing.Size(179, 20);
			this.textBoxTgl.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(5, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Tanggal";
			// 
			// buttonSave
			// 
			this.buttonSave.BackColor = System.Drawing.Color.Chartreuse;
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSave.Location = new System.Drawing.Point(117, 205);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(82, 30);
			this.buttonSave.TabIndex = 3;
			this.buttonSave.Text = "SAVE";
			this.buttonSave.UseVisualStyleBackColor = false;
			this.buttonSave.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBoxNom
			// 
			this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNom.Location = new System.Drawing.Point(95, 81);
			this.textBoxNom.Name = "textBoxNom";
			this.textBoxNom.Size = new System.Drawing.Size(179, 20);
			this.textBoxNom.TabIndex = 2;
			// 
			// textBoxKep
			// 
			this.textBoxKep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxKep.Location = new System.Drawing.Point(95, 119);
			this.textBoxKep.Name = "textBoxKep";
			this.textBoxKep.Size = new System.Drawing.Size(179, 20);
			this.textBoxKep.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(5, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nominal Rp";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(5, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Keperluan";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(347, 44);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(443, 234);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// buttonDel
			// 
			this.buttonDel.BackColor = System.Drawing.Color.Red;
			this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDel.Location = new System.Drawing.Point(577, 293);
			this.buttonDel.Name = "buttonDel";
			this.buttonDel.Size = new System.Drawing.Size(83, 33);
			this.buttonDel.TabIndex = 3;
			this.buttonDel.Text = "DELETE";
			this.buttonDel.UseVisualStyleBackColor = false;
			this.buttonDel.Click += new System.EventHandler(this.ButtonDelClick);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(347, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(206, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Riwayat Keuangan";
			// 
			// buttonEdit
			// 
			this.buttonEdit.BackColor = System.Drawing.Color.SkyBlue;
			this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEdit.Location = new System.Drawing.Point(470, 295);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(83, 33);
			this.buttonEdit.TabIndex = 5;
			this.buttonEdit.Text = "UPDATE";
			this.buttonEdit.UseVisualStyleBackColor = false;
			this.buttonEdit.Click += new System.EventHandler(this.ButtonEditClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(814, 358);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.buttonDel);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "APLIKASI REKAP KEUANGAN";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
