namespace CurrencyConverter;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    private void InitializeComponent()
    {
        grpInput = new GroupBox();
        lblRateInfo = new Label();
        cmbCurrency = new ComboBox();
        lblCurrency = new Label();
        txtAmountRub = new TextBox();
        lblAmount = new Label();
        btnConvert = new Button();
        btnClear = new Button();
        grpResult = new GroupBox();
        lblResult = new Label();
        grpInput.SuspendLayout();
        grpResult.SuspendLayout();
        SuspendLayout();
        // 
        // grpInput
        // 
        grpInput.Controls.Add(lblRateInfo);
        grpInput.Controls.Add(cmbCurrency);
        grpInput.Controls.Add(lblCurrency);
        grpInput.Controls.Add(txtAmountRub);
        grpInput.Controls.Add(lblAmount);
        grpInput.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        grpInput.Location = new Point(20, 20);
        grpInput.Name = "grpInput";
        grpInput.Size = new Size(380, 195);
        grpInput.TabIndex = 0;
        grpInput.TabStop = false;
        grpInput.Text = "Параметры конвертации";
        // 
        // lblRateInfo
        // 
        lblRateInfo.AutoSize = true;
        lblRateInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
        lblRateInfo.ForeColor = Color.DimGray;
        lblRateInfo.Location = new Point(20, 155);
        lblRateInfo.Name = "lblRateInfo";
        lblRateInfo.Size = new Size(188, 20);
        lblRateInfo.TabIndex = 4;
        lblRateInfo.Text = "Текущий курс: 1 USD = 92.50 ₽";
        // 
        // cmbCurrency
        // 
        cmbCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCurrency.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        cmbCurrency.FormattingEnabled = true;
        cmbCurrency.Location = new Point(20, 115);
        cmbCurrency.Name = "cmbCurrency";
        cmbCurrency.Size = new Size(340, 31);
        cmbCurrency.TabIndex = 3;
        cmbCurrency.SelectedIndexChanged += cmbCurrency_SelectedIndexChanged;
        // 
        // lblCurrency
        // 
        lblCurrency.AutoSize = true;
        lblCurrency.Location = new Point(20, 90);
        lblCurrency.Name = "lblCurrency";
        lblCurrency.Size = new Size(134, 21);
        lblCurrency.TabIndex = 2;
        lblCurrency.Text = "Целевая валюта:";
        // 
        // txtAmountRub
        // 
        txtAmountRub.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        txtAmountRub.Location = new Point(20, 52);
        txtAmountRub.Name = "txtAmountRub";
        txtAmountRub.PlaceholderText = "Например: 10000";
        txtAmountRub.Size = new Size(340, 30);
        txtAmountRub.TabIndex = 1;
        // 
        // lblAmount
        // 
        lblAmount.AutoSize = true;
        lblAmount.Location = new Point(20, 28);
        lblAmount.Name = "lblAmount";
        lblAmount.Size = new Size(170, 21);
        lblAmount.TabIndex = 0;
        lblAmount.Text = "Сумма в рублях (₽):";
        // 
        // btnConvert
        // 
        btnConvert.BackColor = Color.FromArgb(37, 99, 235);
        btnConvert.Cursor = Cursors.Hand;
        btnConvert.FlatStyle = FlatStyle.Flat;
        btnConvert.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        btnConvert.ForeColor = Color.White;
        btnConvert.Location = new Point(20, 230);
        btnConvert.Name = "btnConvert";
        btnConvert.Size = new Size(245, 42);
        btnConvert.TabIndex = 1;
        btnConvert.Text = "Конвертировать";
        btnConvert.UseVisualStyleBackColor = false;
        btnConvert.Click += btnConvert_Click;
        // 
        // btnClear
        // 
        btnClear.BackColor = Color.FromArgb(243, 244, 246);
        btnClear.Cursor = Cursors.Hand;
        btnClear.FlatStyle = FlatStyle.Flat;
        btnClear.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        btnClear.ForeColor = Color.FromArgb(55, 65, 81);
        btnClear.Location = new Point(275, 230);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(125, 42);
        btnClear.TabIndex = 2;
        btnClear.Text = "Очистить";
        btnClear.UseVisualStyleBackColor = false;
        btnClear.Click += btnClear_Click;
        // 
        // grpResult
        // 
        grpResult.Controls.Add(lblResult);
        grpResult.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        grpResult.Location = new Point(20, 285);
        grpResult.Name = "grpResult";
        grpResult.Size = new Size(380, 85);
        grpResult.TabIndex = 3;
        grpResult.TabStop = false;
        grpResult.Text = "Результат расчета";
        // 
        // lblResult
        // 
        lblResult.AutoEllipsis = true;
        lblResult.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
        lblResult.ForeColor = Color.FromArgb(16, 120, 60);
        lblResult.Location = new Point(15, 30);
        lblResult.Name = "lblResult";
        lblResult.Size = new Size(350, 40);
        lblResult.TabIndex = 0;
        lblResult.Text = "Результат отобразится здесь";
        lblResult.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(250, 250, 252);
        ClientSize = new Size(420, 395);
        Controls.Add(grpResult);
        Controls.Add(btnClear);
        Controls.Add(btnConvert);
        Controls.Add(grpInput);
        Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Конвертер валют";
        grpInput.ResumeLayout(false);
        grpInput.PerformLayout();
        grpResult.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private GroupBox grpInput;
    private Label lblAmount;
    private TextBox txtAmountRub;
    private Label lblCurrency;
    private ComboBox cmbCurrency;
    private Label lblRateInfo;
    private Button btnConvert;
    private Button btnClear;
    private GroupBox grpResult;
    private Label lblResult;
}
