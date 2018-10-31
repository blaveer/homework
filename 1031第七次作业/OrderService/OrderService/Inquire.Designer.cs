namespace OrderService
{
    partial class Inquire
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.queryInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEcho = new System.Windows.Forms.Label();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.queryInput);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 54);
            this.panel1.TabIndex = 0;
            // 
            // queryInput
            // 
            this.queryInput.Location = new System.Drawing.Point(51, 16);
            this.queryInput.Margin = new System.Windows.Forms.Padding(4);
            this.queryInput.Name = "queryInput";
            this.queryInput.Size = new System.Drawing.Size(136, 25);
            this.queryInput.TabIndex = 1;
            this.queryInput.Text = "1";
            this.queryInput.TextChanged += new System.EventHandler(this.queryInput_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEcho
            // 
            this.lblEcho.AutoSize = true;
            this.lblEcho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Name", true));
            this.lblEcho.Location = new System.Drawing.Point(123, 9);
            this.lblEcho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEcho.Name = "lblEcho";
            this.lblEcho.Size = new System.Drawing.Size(37, 15);
            this.lblEcho.TabIndex = 2;
            this.lblEcho.Text = "（）";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderDetatils);
            this.orderBindingSource.CurrentChanged += new System.EventHandler(this.orderBindingSource_CurrentChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblEcho);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 521);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 41);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "选中订单：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel3.Size = new System.Drawing.Size(1067, 467);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNumberDataGridViewTextBoxColumn,
            this.OrderQuantityDataGridViewTextBoxColumn,
            this.ProductNameDataGridViewTextBoxColumn,
            this.ClientDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1041, 443);
            this.dataGridView1.TabIndex = 0;
            // 
            // OrderNumberDataGridViewTextBoxColumn
            // 
            this.OrderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.OrderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.OrderNumberDataGridViewTextBoxColumn.Name = "OrderNumberDataGridViewTextBoxColumn";
            // 
            // OrderQuantityDataGridViewTextBoxColumn
            // 
            this.OrderQuantityDataGridViewTextBoxColumn.DataPropertyName = "OrderQuantity";
            this.OrderQuantityDataGridViewTextBoxColumn.HeaderText = "OrderQuantity";
            this.OrderQuantityDataGridViewTextBoxColumn.Name = "OrderQuantityDataGridViewTextBoxColumn";
            // 
            // ProductNameDataGridViewTextBoxColumn
            // 
            this.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn";
            // 
            // ClientDataGridViewTextBoxColumn
            // 
            this.ClientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.ClientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.ClientDataGridViewTextBoxColumn.Name = "ClientDataGridViewTextBoxColumn";
            // 
            // Inquire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inquire";
            this.Text = "Inquire";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblEcho;
        private System.Windows.Forms.TextBox queryInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientDataGridViewTextBoxColumn;
    }
}