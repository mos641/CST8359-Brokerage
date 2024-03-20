﻿/*
i. string Id
    1. make sure this is not database generated by setting the DatabaseGenerated attribute to DatabaseGeneratedOption.None
    2. Display name should read ‘Registration Number’
    3. Add the ‘Required’ attribute
ii. string Title
    1. Add the ‘Required’ attribute
    2. Add the ‘StringLength’ attribute, with a value of max 50 and MinimumLength = 3
iii. decimal Fee
    1. Add attributes to define data type currency and column type money
        a. [DataType(DataType.Currency)]
        b. [Column(TypeName = "money")]


5. Refer to the lecture, and add the proper navigational properties to Subscription, Client and Brokerage models
    a. For Navigational properties you define in Client and Brokerage models, name both Subscriptions, and make sure that they navigate to Subscription model
*/

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab4.Models
{
    public class Brokerage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Registration Number")]
        [Required]
        public string Id { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Fee { get; set; }

        public ICollection<Subscription> Subscriptions { get; set; }
    }
}
