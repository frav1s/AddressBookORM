using AddressBookLibrary.Model;

namespace AddressBookLibrary
{
    public interface IContactRequestor
    {
        void ContactComplete(Person contact);
    }
}