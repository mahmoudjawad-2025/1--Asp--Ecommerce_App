using DAL.Models.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL.DTO.Requests
{
    public class CheckOutRequest
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PaymentMethodEnum PaymentMethod { get; set; } = PaymentMethodEnum.Visa;
    }
}
