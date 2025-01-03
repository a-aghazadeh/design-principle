namespace Solid.ISP.Demo01.Resolve;

public interface IFullDevice
{
    void Print(string content);
    void Scan(string content);
    void Fax(string content);
    void PhotoCopy(string content);
}
