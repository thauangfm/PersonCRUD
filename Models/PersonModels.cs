namespace Person.Models;

public class PersonModel {
    public PersonModel(string name, int phone, string email)
    {
        Name = name;
        Phone = phone;
        Email = email;
        Id = Guid.NewGuid();
    }
    public Guid Id { get; init; }
    public string Name { get; private set; }
    public int Phone { get; init; }
    public string Email { get; init; }

    public void ChangeName(string name)
    {
        Name = name;
    }

    public void SetInactive()
    {
        Name = "desativado";
    }
}
