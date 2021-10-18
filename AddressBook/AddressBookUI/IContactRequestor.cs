using AddressBookLibrary.Model;

namespace AddressBookUI
{
    public interface IContactRequestor
    {
        void ContactComplete(Person contact);
    }
}