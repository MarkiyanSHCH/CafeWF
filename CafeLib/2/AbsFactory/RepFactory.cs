using System.Configuration;
using CafeLib.Models;
using CafeLib.Repository;


public abstract class RepositoryFactory
{
    public abstract IRepository<Employee> GetEmpRepository();
    public abstract IRepository<Customer> GetCustRepository();
    public abstract IRepository<Driver> GetDrivRepository();
}

public class Client {

    public static RepositoryFactory CreateData()
    {
        var factoryType = ConfigurationManager.AppSettings["factoryType"];

        if (factoryType.Equals("TXT"))
            return new TXTDataFactory();
        else if (factoryType.Equals("XML"))
            return new XMLDataFactory();
        else if (factoryType.Equals("Array"))
            return new ArrayFactory();
        else
            return null;
    }

}

public class TXTDataFactory : RepositoryFactory
{

    public override IRepository<Employee> GetEmpRepository()
    {
        return new CafeLib.Repository.TXT.EmployeeRep();
    }
    public override IRepository<Customer> GetCustRepository()
    {
        return new CafeLib.Repository.TXT.CustomerRep();
    }
    public override IRepository<Driver> GetDrivRepository()
    {
        return new CafeLib.Repository.TXT.DriverRep();
    }


}

public class XMLDataFactory : RepositoryFactory
{

    public override IRepository<Employee> GetEmpRepository()
    {
        return new CafeLib.Repository.XML.EmployeeRep();
    }
    public override IRepository<Customer> GetCustRepository()
    {
        return new CafeLib.Repository.XML.CustomerRep();
    }
    public override IRepository<Driver> GetDrivRepository()
    {
        return new CafeLib.Repository.XML.DriverRep();
    }


}

public class ArrayFactory : RepositoryFactory
{
    
    public override IRepository<Employee> GetEmpRepository()
    {
        return new CafeLib.Repository.Array.Repository<Employee>();
    }
    public override IRepository<Customer> GetCustRepository()
    {
        return new CafeLib.Repository.Array.Repository<Customer>();
    }
    public override IRepository<Driver> GetDrivRepository()
    {
        return new CafeLib.Repository.Array.Repository<Driver>();
    }
}
