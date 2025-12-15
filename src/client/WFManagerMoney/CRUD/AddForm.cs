using BrothersBlog.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFManagerMoney.CRUD
{
    public partial class AddForm: Form
    {
        private readonly Dictionary<string, Control> _inputControls = new();
        private readonly Dictionary<string, Label> _labels = new();
        private readonly HashSet<string> _requiredFields = new();
        private readonly Type? _modelForm;

        public AddForm(Type? modelForm)
        {
            InitializeComponent();

            this._modelForm = modelForm;
            GenerateFields();
        }

        private void GenerateFields()
        {
            var type = _modelForm;
            int y = 10;

            // Lấy property theo thứ tự khai báo: base class trước, rồi đến class con
            var props = new List<PropertyInfo>();
            var baseType = type.BaseType;
            if (baseType != null && baseType != typeof(object))
            {
                props.AddRange(baseType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            }
            props.AddRange(type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            foreach (var prop in props)
            {
                bool isNullable = Nullable.GetUnderlyingType(prop.PropertyType) != null || (prop.PropertyType.IsClass && prop.PropertyType != typeof(string));
                bool isRequired = !isNullable && prop.PropertyType != typeof(string);

                // Mark required fields with *
                string labelText = prop.Name + (isRequired ? " *" : "");

                var label = new Label
                {
                    Text = labelText,
                    Location = new Point(10, y),
                    AutoSize = true,
                    ForeColor = isRequired ? Color.Red : SystemColors.ControlText
                };
                Controls.Add(label);
                _labels[prop.Name] = label;

                // Input
                Control input;
                var actualType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                if (actualType == typeof(DateTime))
                {
                    input = new DateTimePicker
                    {
                        Location = new Point(150, y),
                        Width = 200
                    };
                }
                else if (actualType == typeof(decimal) || actualType == typeof(int))
                {
                    input = new NumericUpDown
                    {
                        Location = new Point(150, y),
                        Width = 200,
                        Maximum = decimal.MaxValue
                    };
                }
                else if (actualType.IsEnum)
                {
                    input = new ComboBox
                    {
                        Location = new Point(150, y),
                        Width = 200,
                        DropDownStyle = ComboBoxStyle.DropDownList,
                        DataSource = Enum.GetValues(actualType)
                    };
                }
                else
                {
                    input = new TextBox
                    {
                        Location = new Point(150, y),
                        Width = 200
                    };
                }

                Controls.Add(input);
                _inputControls[prop.Name] = input;

                if (isRequired)
                    _requiredFields.Add(prop.Name);

                y += 35;
            }

            // Add Save button
            var btnSave = new Button
            {
                Text = "Lưu",
                Location = new Point(150, y)
            };
            btnSave.Click += BtnSave_Click;
            Controls.Add(btnSave);

            this.ClientSize = new Size(400, y + 50);
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            var obj = new ContractInstallmentPayment();
            var type = obj.GetType();

            // Validate required fields
            foreach (var field in _requiredFields)
            {
                if (_inputControls.TryGetValue(field, out var control))
                {
                    bool isEmpty = false;
                    if (control is TextBox tb)
                        isEmpty = string.IsNullOrWhiteSpace(tb.Text);
                    else if (control is NumericUpDown nud)
                        isEmpty = nud.Value == 0;
                    else if (control is ComboBox cb)
                        isEmpty = cb.SelectedItem == null;
                    else if (control is DateTimePicker dtp)
                        isEmpty = dtp.Value == default;

                    if (isEmpty)
                    {
                        MessageBox.Show($"Vui lòng nhập {field}!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control.Focus();
                        return;
                    }
                }
            }

            // Collect data
            foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (_inputControls.TryGetValue(prop.Name, out var control))
                {
                    object? value = null;
                    var actualType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

                    if (control is TextBox tb)
                        value = string.IsNullOrWhiteSpace(tb.Text) ? null : tb.Text;
                    else if (control is NumericUpDown nud)
                        value = Convert.ChangeType(nud.Value, actualType);
                    else if (control is DateTimePicker dtp)
                        value = dtp.Value;
                    else if (control is ComboBox cb && actualType.IsEnum)
                        value = cb.SelectedItem;

                    if (value != null)
                        prop.SetValue(obj, value);
                }
            }

            // TODO: handle obj (save, add to list, etc.)
            MessageBox.Show("Đã lưu hợp đồng trả góp!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
