Feature: API testing

Scenario Outline: Register a new User with correct credentials
When I register a new User with '<Email>' Username and '<password>' Password
Then registration is sucessfull 
And token is generated


Examples: 
| Email              | password |
| eve.holt@reqres.in |  pistol  |

Scenario Outline: Register a new User with only email
When I register a new User with '<Email>' username
Then registration is unsucessfull 
And An error accured


Examples: 
| Email              |
| eve.holt@reqres.in |

Scenario: want to open list of user
When I click on user list
Then users list opened
