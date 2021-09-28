namespace Яхтенная_верфь
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.яхтенная_ВерфьDataSet = new Яхтенная_верфь.Яхтенная_ВерфьDataSet();
            this.аксессуарыЛодочныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аксессуары_лодочныеTableAdapter = new Яхтенная_верфь.Яхтенная_ВерфьDataSetTableAdapters.Аксессуары_лодочныеTableAdapter();
            this.fitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.яхтенная_ВерфьDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аксессуарыЛодочныеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fitIDDataGridViewTextBoxColumn,
            this.accessoryIDDataGridViewTextBoxColumn,
            this.boatIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.аксессуарыЛодочныеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // яхтенная_ВерфьDataSet
            // 
            this.яхтенная_ВерфьDataSet.DataSetName = "Яхтенная_ВерфьDataSet";
            this.яхтенная_ВерфьDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // аксессуарыЛодочныеBindingSource
            // 
            this.аксессуарыЛодочныеBindingSource.DataMember = "Аксессуары лодочные";
            this.аксессуарыЛодочныеBindingSource.DataSource = this.яхтенная_ВерфьDataSet;
            // 
            // аксессуары_лодочныеTableAdapter
            // 
            this.аксессуары_лодочныеTableAdapter.ClearBeforeFill = true;
            // 
            // fitIDDataGridViewTextBoxColumn
            // 
            this.fitIDDataGridViewTextBoxColumn.DataPropertyName = "Fit_ID";
            this.fitIDDataGridViewTextBoxColumn.HeaderText = "Fit_ID";
            this.fitIDDataGridViewTextBoxColumn.Name = "fitIDDataGridViewTextBoxColumn";
            // 
            // accessoryIDDataGridViewTextBoxColumn
            // 
            this.accessoryIDDataGridViewTextBoxColumn.DataPropertyName = "Accessory_ID";
            this.accessoryIDDataGridViewTextBoxColumn.HeaderText = "Accessory_ID";
            this.accessoryIDDataGridViewTextBoxColumn.Name = "accessoryIDDataGridViewTextBoxColumn";
            // 
            // boatIDDataGridViewTextBoxColumn
            // 
            this.boatIDDataGridViewTextBoxColumn.DataPropertyName = "Boat_ID";
            this.boatIDDataGridViewTextBoxColumn.HeaderText = "Boat_ID";
            this.boatIDDataGridViewTextBoxColumn.Name = "boatIDDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Playbill", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Аксессуары лодочные";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(125, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(511, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Далее";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Аксессуары лодочные";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.яхтенная_ВерфьDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аксессуарыЛодочныеBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Яхтенная_ВерфьDataSet яхтенная_ВерфьDataSet;
        private System.Windows.Forms.BindingSource аксессуарыЛодочныеBindingSource;
        private Яхтенная_ВерфьDataSetTableAdapters.Аксессуары_лодочныеTableAdapter аксессуары_лодочныеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}