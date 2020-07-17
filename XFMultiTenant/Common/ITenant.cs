using System.Drawing;

namespace XFMultiTenant.Common
{
    public interface ITenant
    {
        string Name { get; }
        string Url { get; }

        Color PrimaryColor { get; }
        Color SecondaryColor { get; }
    }
}
