using System;
using System.Collections.Generic;

namespace ESFCustomersData.Models;

public class Symvolaia
{
    public string? CUSCODE { get; set; } = null!;

    public string? CUSNAME { get; set; } = null!;

    public string? afm { get; set; }

    public string? phone01 { get; set; }

    public string? phone02 { get; set; }

    public string? MCODE { get; set; } = null!;

    public string? MNAME { get; set; } = null!;

    public DateTime? LSALEDATE { get; set; } = null;

    public double? PRICE { get; set; }

    public double? DISCPRC { get; set; }

    public double? QTY1 { get; set; }

    public DateTime? date01 { get; set; }= null;

    public double? fprice { get; set; }

    public double? tqty { get; set; }

    public string? fpist { get; set; }
}
