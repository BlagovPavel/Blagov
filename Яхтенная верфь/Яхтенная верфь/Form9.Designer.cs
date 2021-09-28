namespace Яхтенная_верфь
{
    partial class Form9
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boatTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfRoversDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.woodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.лодкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.яхтенная_ВерфьDataSet6 = new Яхтенная_верфь.Яхтенная_ВерфьDataSet6();
            this.лодкиTableAdapter = new Яхтенная_верфь.Яхтенная_ВерфьDataSet6TableAdapters.ЛодкиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лодкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.яхтенная_ВерфьDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(512, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Далее";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(126, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Playbill", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Лодки";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boatIDDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.boatTypeDataGridViewTextBoxColumn,
            this.numberOfRoversDataGridViewTextBoxColumn,
            this.mastDataGridViewTextBoxColumn,
            this.colourDataGridViewTextBoxColumn,
            this.woodDataGridViewTextBoxColumn,
            this.basePriceDataGridViewTextBoxColumn,
            this.vATDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.лодкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 326);
            this.dataGridView1.TabIndex = 16;
            // 
            // boatIDDataGridViewTextBoxColumn
            // 
            this.boatIDDataGridViewTextBoxColumn.DataPropertyName = "boat_ID";
            this.boatIDDataGridViewTextBoxColumn.HeaderText = "boat_ID";
            this.boatIDDataGridViewTextBoxColumn.Name = "boatIDDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // boatTypeDataGridViewTextBoxColumn
            // 
            this.boatTypeDataGridViewTextBoxColumn.DataPropertyName = "BoatType";
            this.boatTypeDataGridViewTextBoxColumn.HeaderText = "BoatType";
            this.boatTypeDataGridViewTextBoxColumn.Name = "boatTypeDataGridViewTextBoxColumn";
            // 
            // numberOfRoversDataGridViewTextBoxColumn
            // 
            this.numberOfRoversDataGridViewTextBoxColumn.DataPropertyName = "NumberOfRovers";
            this.numberOfRoversDataGridViewTextBoxColumn.HeaderText = "NumberOfRovers";
            this.numberOfRoversDataGridViewTextBoxColumn.Name = "numberOfRoversDataGridViewTextBoxColumn";
            // 
            // mastDataGridViewTextBoxColumn
            // 
            this.mastDataGridViewTextBoxColumn.DataPropertyName = "Mast";
            this.mastDataGridViewTextBoxColumn.HeaderText = "Mast";
            this.mastDataGridViewTextBoxColumn.Name = "mastDataGridViewTextBoxColumn";
            // 
            // colourDataGridViewTextBoxColumn
            // 
            this.colourDataGridViewTextBoxColumn.DataPropertyName = "Colour";
            this.colourDataGridViewTextBoxColumn.HeaderText = "Colour";
            this.colourDataGridViewTextBoxColumn.Name = "colourDataGridViewTextBoxColumn";
            // 
            // woodDataGridViewTextBoxColumn
            // 
            this.woodDataGridViewTextBoxColumn.DataPropertyName = "Wood";
            this.woodDataGridViewTextBoxColumn.HeaderText = "Wood";
            this.woodDataGridViewTextBoxColumn.Name = "woodDataGridViewTextBoxColumn";
            // 
            // basePriceDataGridViewTextBoxColumn
            // 
            this.basePriceDataGridViewTextBoxColumn.DataPropertyName = "BasePrice";
            this.basePriceDataGridViewTextBoxColumn.HeaderText = "BasePrice";
            this.basePriceDataGridViewTextBoxColumn.Name = "basePriceDataGridViewTextBoxColumn";
            // 
            // vATDataGridViewTextBoxColumn
            // 
            this.vATDataGridViewTextBoxColumn.DataPropertyName = "VAT";
            this.vATDataGridViewTextBoxColumn.HeaderText = "VAT";
            this.vATDataGridViewTextBoxColumn.Name = "vATDataGridViewTextBoxColumn";
            // 
            // лодкиBindingSource
            // 
            this.лодкиBindingSource.DataMember = "Лодки";
            this.лодкиBindingSource.DataSource = this.яхтенная_ВерфьDataSet6;
            // 
            // яхтенная_ВерфьDataSet6
            // 
            this.яхтенная_ВерфьDataSet6.DataSetName = "Яхтенная_ВерфьDataSet6";
            this.яхтенная_ВерфьDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // лодкиTableAdapter
            // 
            this.лодкиTableAdapter.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Text = "Лодки";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лодкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.яхтенная_ВерфьDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Яхтенная_ВерфьDataSet6 яхтенная_ВерфьDataSet6;
        private System.Windows.Forms.BindingSource лодкиBindingSource;
        private Яхтенная_ВерфьDataSet6TableAdapters.ЛодкиTableAdapter лодкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfRoversDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn woodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATDataGridViewTextBoxColumn;
    }
}