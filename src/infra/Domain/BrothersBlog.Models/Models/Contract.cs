using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrothersBlog.Models.Models
{
    public enum ContractType
    {
        Processing,
        Pending,
        Success,
        Failed,
    }

    public enum DeviceType
    {
        Car,
        Bike,
        Moto,
        Phone,
        Tivi,
        Laptop,
        Other,
    }

    public class Contract
    {
        public string Id { get; set; }

        public string CustomerName { get; set; }

        public string PhoneNumber { get; set; }

        public string? Address { get; set; }

        public string? CCCD { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public ContractType ContractType { get; set; }
    }

    /// <summary>
    /// Hợp đồng trả góp
    /// </summary>
    public class ContractInstallmentPayment : Contract
    {
        /// <summary>
        /// tiền vay
        /// </summary>
        public decimal LoanAmount { get; set; }

        /// <summary>
        /// lãi suất
        /// </summary>
        public decimal InterestRate { get; set; }

        /// <summary>
        /// tổng tiền phải trả
        /// </summary>
        public decimal TotalAmount { get; set; }
    }

    /// <summary>
    /// Cầm đồ
    /// </summary>
    public class ContractPawnShop : Contract
    {
        /// <summary>
        /// thông tin sản phẩm
        /// </summary>
        public string Information { get; set; }

        /// <summary>
        /// ngày đến hạn
        /// </summary>
        public DeviceType DeviceType { get; set; }

        /// <summary>
        /// tiền cầm đồ
        /// </summary>
        public decimal PawnMoney { get; set; }

        /// <summary>
        /// tiền cầm đồ
        /// </summary>
        public decimal RansomMoney { get; set; }
    }
}
