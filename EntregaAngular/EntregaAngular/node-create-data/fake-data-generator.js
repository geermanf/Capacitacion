var fs = require('fs');
var faker = require('faker');
var Q = require('q');

var data = { users: [] };

for (var i = 1; i <= 20; i++) {

  var year = faker.random.number({min:1750, max: 1990});
  var firstName = faker.name.firstName();
  var lastName = faker.name.lastName();

  data.users.push({
    id: i,
    phone: faker.helpers.replaceSymbolWithNumber('(###) ####-####'),
    userName: firstName.toLowerCase() + '.' + lastName.toLowerCase(),
    firstName: firstName,
    lastName: lastName,
    dateOfBirth: faker.date.past(year),
    photo: faker.image.avatar(),
    namePrefix: faker.name.prefix(),
    email: faker.internet.email(firstName.toLowerCase(), lastName.toLowerCase(), 'company.com'),
    address: {
      city: faker.address.city(),
      state: faker.address.state(),
      streetAddress: faker.address.streetAddress(true),
      country: faker.address.country(),
      zipCode: faker.address.zipCode(),
    },
    job: {
      jobArea: faker.name.jobArea(),
      jobTitle: faker.name.jobTitle(),
      jobType: faker.name.jobType(),
    }
  });
}

var file_name = 'db-users-data.json';

if (fs.existsSync(file_name)) {
	fs.unlinkSync(file_name);
}

var json = JSON.stringify(data);

(function(file_name, data) {
	var defer = Q.defer();

	fs.writeFile(file_name, json, 'utf8', function(err) {
		if (err) {
			defer.reject(err);
		} else {
			defer.resolve('write ok');
		}
  });
  
  return defer.promise;
})(file_name, json)
	.then(function(msg) {
		console.log(msg);
	})
	.catch(function(err) {
		console.error(err);
	});

