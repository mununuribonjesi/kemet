export class MailingList {
  emailAddress: String;
  firstName: String;
  lastName: String;
  dobDay: Number;
  dobMonth: Number;
  dobYear: Number

  new() {

    this.emailAddress = null;
    this.firstName = null;
    this.lastName = null;
    this.dobDay = null;
    this.dobMonth = null;
    this.dobYear = null;
  }
}
