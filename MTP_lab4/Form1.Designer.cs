
namespace MTP_lab4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radiologie_dbDataSet = new MTP_lab4.radiologie_dbDataSet();
            this.pacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientiTableAdapter = new MTP_lab4.radiologie_dbDataSetTableAdapters.PacientiTableAdapter();
            this.tableAdapterManager = new MTP_lab4.radiologie_dbDataSetTableAdapters.TableAdapterManager();
            this.radiografiiTableAdapter = new MTP_lab4.radiologie_dbDataSetTableAdapters.RadiografiiTableAdapter();
            this.pacientiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.addRadiography = new System.Windows.Forms.Button();
            this.saveChanges = new System.Windows.Forms.Button();
            this.radiografiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radiologie_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiografiiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radiologie_dbDataSet
            // 
            this.radiologie_dbDataSet.DataSetName = "radiologie_dbDataSet";
            this.radiologie_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientiBindingSource
            // 
            this.pacientiBindingSource.DataMember = "Pacienti";
            this.pacientiBindingSource.DataSource = this.radiologie_dbDataSet;
            this.pacientiBindingSource.PositionChanged += new System.EventHandler(this.pacientiBindingSource_PositionChanged);
            // 
            // pacientiTableAdapter
            // 
            this.pacientiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PacientiTableAdapter = this.pacientiTableAdapter;
            this.tableAdapterManager.RadiografiiTableAdapter = this.radiografiiTableAdapter;
            this.tableAdapterManager.UpdateOrder = MTP_lab4.radiologie_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // radiografiiTableAdapter
            // 
            this.radiografiiTableAdapter.ClearBeforeFill = true;
            // 
            // pacientiDataGridView
            // 
            this.pacientiDataGridView.AutoGenerateColumns = false;
            this.pacientiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacientiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pacientiDataGridView.DataSource = this.pacientiBindingSource;
            this.pacientiDataGridView.Location = new System.Drawing.Point(12, 12);
            this.pacientiDataGridView.Name = "pacientiDataGridView";
            this.pacientiDataGridView.RowHeadersWidth = 51;
            this.pacientiDataGridView.RowTemplate.Height = 24;
            this.pacientiDataGridView.Size = new System.Drawing.Size(447, 398);
            this.pacientiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CNP";
            this.dataGridViewTextBoxColumn1.HeaderText = "CNP";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(465, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(109, 442);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(580, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 328);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(580, 346);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.ReadOnly = true;
            this.detailsTextBox.Size = new System.Drawing.Size(571, 108);
            this.detailsTextBox.TabIndex = 4;
            // 
            // addRadiography
            // 
            this.addRadiography.Location = new System.Drawing.Point(12, 416);
            this.addRadiography.Name = "addRadiography";
            this.addRadiography.Size = new System.Drawing.Size(187, 38);
            this.addRadiography.TabIndex = 5;
            this.addRadiography.Text = "Adauga radiografie";
            this.addRadiography.UseVisualStyleBackColor = true;
            this.addRadiography.Click += new System.EventHandler(this.addRadiography_Click);
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(272, 416);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(187, 38);
            this.saveChanges.TabIndex = 6;
            this.saveChanges.Text = "Salveaza modificari";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // radiografiiBindingSource
            // 
            this.radiografiiBindingSource.DataMember = "FK__Radiografii__CNP__25869641";
            this.radiografiiBindingSource.DataSource = this.pacientiBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 466);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.addRadiography);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pacientiDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radiologie_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiografiiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private radiologie_dbDataSet radiologie_dbDataSet;
        private System.Windows.Forms.BindingSource pacientiBindingSource;
        private radiologie_dbDataSetTableAdapters.PacientiTableAdapter pacientiTableAdapter;
        private radiologie_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pacientiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private radiologie_dbDataSetTableAdapters.RadiografiiTableAdapter radiografiiTableAdapter;
        private System.Windows.Forms.BindingSource radiografiiBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.Button addRadiography;
        private System.Windows.Forms.Button saveChanges;
    }
}

