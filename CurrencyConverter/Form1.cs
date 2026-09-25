using System.Globalization;

namespace CurrencyConverter;

public partial class Form1 : Form
{
    // Описание поддерживаемых валют: Код, Название, Символ, Курс к рублю (стоимость 1 единицы в рублях)
    private record CurrencyInfo(string Code, string Name, string Symbol, double RateToRub);

    private readonly List<CurrencyInfo> _currencies = new()
    {
        new("USD", "Доллар США", "$", 92.50),
        new("EUR", "Евро", "€", 101.20),
        new("CNY", "Китайский юань", "¥", 13.10),
        new("GBP", "Фунт стерлингов", "£", 120.40),
        new("BYN", "Белорусский рубль", "Br", 28.50),
        new("KZT", "Казахстанский тенге", "₸", 0.19),
        new("AED", "Дирхам ОАЭ", "AED", 25.20)
    };

    public Form1()
    {
        InitializeComponent();
        InitializeCurrenciesList();
    }

    /// <summary>
    /// Заполнение выпадающего списка доступными валютами
    /// </summary>
    private void InitializeCurrenciesList()
    {
        cmbCurrency.Items.Clear();
        foreach (var c in _currencies)
        {
            cmbCurrency.Items.Add($"{c.Code} — {c.Name} ({c.Symbol})");
        }

        // По умолчанию выбираем первую валюту (USD)
        if (cmbCurrency.Items.Count > 0)
        {
            cmbCurrency.SelectedIndex = 0;
        }
    }

    /// <summary>
    /// Обработчик изменения выбранной валюты
    /// </summary>
    private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cmbCurrency.SelectedIndex >= 0 && cmbCurrency.SelectedIndex < _currencies.Count)
        {
            var currency = _currencies[cmbCurrency.SelectedIndex];
            lblRateInfo.Text = $"Текущий курс: 1 {currency.Code} = {currency.RateToRub:F2} ₽";
        }
    }

    /// <summary>
    /// Обработчик нажатия кнопки «Конвертировать»
    /// </summary>
    private void btnConvert_Click(object sender, EventArgs e)
    {
        // 1. Проверка на пустое значение
        if (string.IsNullOrWhiteSpace(txtAmountRub.Text))
        {
            MessageBox.Show("Пожалуйста, введите сумму в рублях.",
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txtAmountRub.Focus();
            return;
        }

        // 2. Нормализация разделителя дробной части (поддержка точки и запятой)
        string input = txtAmountRub.Text.Trim().Replace(',', '.');

        // 3. Проверка корректности введенного числа
        if (!double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double amountRub))
        {
            MessageBox.Show("Введите корректное числовое значение суммы.",
                "Ошибка ввода",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            txtAmountRub.SelectAll();
            txtAmountRub.Focus();
            return;
        }

        // 4. Проверка на положительность
        if (amountRub <= 0)
        {
            MessageBox.Show("Сумма для конвертации должна быть больше нуля.",
                "Ошибка ввода",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txtAmountRub.SelectAll();
            txtAmountRub.Focus();
            return;
        }

        // 5. Проверка выбора валюты
        if (cmbCurrency.SelectedIndex < 0 || cmbCurrency.SelectedIndex >= _currencies.Count)
        {
            MessageBox.Show("Пожалуйста, выберите валюту из списка.",
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        // 6. Вычисление конвертированной суммы
        var selectedCurrency = _currencies[cmbCurrency.SelectedIndex];
        double convertedAmount = amountRub / selectedCurrency.RateToRub;

        // 7. Вывод результата пользователю
        lblResult.Text = $"{amountRub:N2} ₽  =  {convertedAmount:N2} {selectedCurrency.Code} ({selectedCurrency.Symbol})";
    }

    /// <summary>
    /// Обработчик кнопки «Очистить»
    /// </summary>
    private void btnClear_Click(object sender, EventArgs e)
    {
        txtAmountRub.Clear();
        lblResult.Text = "Результат отобразится здесь";
        if (cmbCurrency.Items.Count > 0)
        {
            cmbCurrency.SelectedIndex = 0;
        }
        txtAmountRub.Focus();
    }
}
