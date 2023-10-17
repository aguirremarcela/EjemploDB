// See https://aka.ms/new-console-template for more information

using EntityFrameworkDB.Data;
using EntityFrameworkDB.Data.Models;
using EntityFrameworkDB.Data.Repository;

DataDBContext ob= new DataDBContext();
/*PersonsRepository pr = new PersonsRepository(ob);
Persons p = new Persons();
p.Name = "Pedro";
p.Deleted = null;
p.Created=DateTime.Now;
p.Updated=DateTime.Now;
pr.Insert(p);*/

ReceiptRepository prRepository = new ReceiptRepository(ob);
Receipts r= new Receipts();
r.Date = DateTime.Now;
r.IdCustomer = 1;
r.Deleted = null;
r.Created = DateTime.Now;
r.Updated = DateTime.Now;
prRepository.Insert(r);

Console.WriteLine("********Bienvenidos********");



