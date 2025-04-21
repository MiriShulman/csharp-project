
namespace DO;

public record Sale
(
    //public static int index = 100;
    int code,
    int id,
    int? minimumAmount = null,
    double? sum = null,
    bool? isNeedClub = false,
    DateTime? beginSale = null,
    DateTime? endSale = null
)
{
    public Sale() : this(0, 0)
    {

    }
}


