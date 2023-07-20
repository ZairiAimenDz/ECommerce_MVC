﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class BuyerDetails
    {
        public Guid ID { get; set; }
        [Required]
        public string Email{ get; set; }
        [Required]
        public string ClientName { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string PaymentEvidenceImg { get; set; }
    }

    public enum PaymentMethod
    {
        CCP,
        Hand_to_Hand,
        Payment_On_Delivery,
        CheckOut_At_Store
    }
}
