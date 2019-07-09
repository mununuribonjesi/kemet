export class Subscribers {
  subscriptionID: String;
  firstName: String;
  lastName: String;
  gender: String;
  birthDate: Date;
  countryID: String;
  emailID: String;
  city: String;

  new() {
    this.subscriptionID = null;
    this.firstName = null;
    this.gender = null;
    this.birthDate = null;
    this.countryID = null;
    this.emailID = null;
    this.city = null;
  }
}
