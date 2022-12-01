using PracticWork9;

List<Phone> phones = new List<Phone>();


PersonCreate person = new PersonCreate();
phones.Add(person.GenerateNote("Дмитрий", 1234));

IndividualCreate individual = new IndividualCreate();
phones.Add(individual.GenerateNote("ООО Форвард", 1010));

InstitutionCreate institution = new InstitutionCreate();
phones.Add(institution.GenerateNote("ОКЭИ", 9999));

foreach (var item in phones)
{
    Console.WriteLine(item.GetInfo());
}