using AddressBookLibrary.Model;

namespace AddressBookService
{
    public interface IContactRequestor
    {
        void ContactComplete(Person contact);
    }
}