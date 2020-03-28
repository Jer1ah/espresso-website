.navigation {
  display: flex;
  justify-content: space-between;
  align-items: center;
  height: 7.7rem;
  background-color: white;
  position: fixed;
  top: 0;
  z-index: 101;
  width: 100%;
  box-shadow: 0px 19px 29px -2px #666666;
}
.navigation__logo {
  display: flex;
  justify-content: center;
  align-items: center;
  font-size: 3rem;
  margin-left: 4rem;
  color: #B38157;
}
.navigation__logo img {
  height: 4.5rem;
  margin-right: 0.5rem;
  margin-bottom: 0.7rem;
}
.navigation__list {
  list-style: none;
  display: flex;
  justify-content: center;
  align-items: center;
  margin-right: 4rem;
}
.navigation__listItem {
  margin: 0 1.5rem;
}
.navigation__listItem a {
  text-decoration: none;
  font-size: 2rem;
  color: black;
}
.navigation__listItem a:hover {
  color: #B38157;
  cursor: pointer;
}
.navigation__listItem:last-child {
  margin-right: 0;
}

.mobileNav {
  width: 3.5rem;
  display: none;
}

.mobileNav:hover {
  cursor: pointer;
}

.active {
  color: #B38157 !important;
}

@media (max-width: 950px) {
  .navigation {
    height: auto;
    min-height: 7.7rem;
    flex-direction: column;
  }
  .navigation__list {
    display: none;
    flex-direction: column;
    margin: 2rem 0 3rem;
  }
  .navigation__listItem {
    margin: 1rem 0 0;
  }
  .navigation__listItem a {
    color: #B38157;
    font-size: 3rem;
  }
  .navigation__container {
    display: flex;
    justify-content: space-between;
    width: 100%;
    margin-top: 1.3rem;
  }

  .mobileNav {
    display: inline;
    margin-right: 4rem;
  }
}
.miniGallery {
  background-color: #f8f8f8;
}
.miniGallery__list {
  display: flex;
  width: 100%;
  padding: 0;
  margin: 0;
  list-style: none;
  height: auto;
  margin-bottom: -0.5rem;
}
.miniGallery__listItem {
  height: auto;
}
.miniGallery__image {
  width: 100%;
}

@media (max-width: 950px) {
  .miniGallery__list {
    flex-direction: column;
    margin: 0;
  }
  .miniGallery__listItem {
    margin: 0;
    margin-bottom: -1rem;
  }
}
.footer {
  height: 55rem;
  background: url("../../img/footer-image.png");
  background-size: cover;
  background-position: center;
  display: flex;
  color: white;
}

.hours {
  flex: 1;
  background: linear-gradient(rgba(0, 0, 0, 0.6), rgba(0, 0, 0, 0.6));
}
.hours h1 {
  font-size: 5rem;
  margin: 0;
  font-weight: 500;
}
.hours h3 {
  color: #DCA57D;
  font-size: 1.8rem;
  font-weight: 500;
  margin-bottom: 1rem;
}
.hours h5 {
  font-size: 1.5rem;
  margin: 0;
  font-weight: 300;
  margin: 0;
}
.hours button {
  border: none;
  background-color: #dca47d;
  color: white;
  height: 5.5rem;
  width: 16.5rem;
  font-size: 1.6rem;
  letter-spacing: 0.2rem;
  font-family: "Roboto Condensed", sans-serif;
  margin-top: 3rem;
}
.hours button:hover {
  cursor: pointer;
}
.hours__container {
  margin: 10rem 0 0 15rem;
}

.contact {
  flex: 1;
  background-color: black;
}
.contact h1 {
  font-size: 5rem;
  margin: 0;
  font-weight: 500;
}
.contact h3 {
  color: #DCA57D;
  font-size: 1.8rem;
  font-weight: 500;
  margin-bottom: 1rem;
}
.contact h5 {
  font-size: 1.5rem;
  font-weight: 300;
  margin: 0;
}
.contact__container {
  margin: 10rem 0 0 15rem;
}

@media (max-width: 1000px) {
  .footer {
    flex-direction: column;
    height: auto;
  }

  .hours__container {
    margin: 10rem 0 10rem 7rem;
  }

  .contact__container {
    margin: 10rem 0 10rem 7rem;
  }
}
.newsletter {
  height: 50rem;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  text-align: center;
  background-color: #3d3a34;
}
.newsletter__info {
  width: 50rem;
  margin-bottom: 2rem;
}
.newsletter__info h1 {
  font-size: 4rem;
  font-weight: 500;
  margin: 0;
  color: #fff;
}
.newsletter__info p {
  font-size: 1.8rem;
  margin: 1rem auto 2rem;
  color: #fff;
  width: 90%;
}
.newsletter__input {
  display: flex;
  flex-direction: column;
  width: 50rem;
}
.newsletter__input input {
  width: 100%;
  height: 5rem;
  border: none;
  padding: 0;
  margin-bottom: 2rem;
  font-size: 1.6rem;
  text-indent: 1rem;
}
.newsletter__input button {
  border: none;
  width: 100%;
  border: none;
  background-color: #dca47d;
  color: white;
  height: 5.5rem;
  font-size: 1.6rem;
  letter-spacing: 0.2rem;
  font-family: "Roboto Condensed", sans-serif;
}

body, html {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-size: 10px;
  font-family: "Baloo 2", cursive;
}

.header {
  height: 100vh;
  background: url("../../img/header.png");
  background-repeat: no-repeat;
  background-position: center;
  background-size: cover;
  padding: 0.1rem;
}

.heading {
  text-align: center;
  margin: 33rem 0 0;
  color: white;
}
.heading h1 {
  font-size: 7rem;
  margin: 0;
  letter-spacing: 0.2rem;
  font-weight: 500;
}
.heading p {
  font-size: 3rem;
  margin: -1rem 0 4rem;
  font-weight: 300;
}
.heading button {
  border: none;
  background-color: #dca47d;
  color: white;
  height: 5.5rem;
  width: 15rem;
  font-size: 1.6rem;
  letter-spacing: 0.2rem;
  font-family: "Roboto Condensed", sans-serif;
}
.heading button:hover {
  cursor: pointer;
}

@media (max-width: 860px) {
  .heading h1 {
    width: 50rem;
    margin: 0 auto 2rem;
    line-height: 6.6rem;
    font-size: 6rem;
  }
  .heading p {
    font-size: 2.2rem;
  }
}
.mainCoffee {
  background: url("../../img//coffee-grounds.png");
  background-position: center;
  background-size: cover;
  padding: 0.1rem;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}
.mainCoffee h1 {
  text-align: center;
  font-size: 5rem;
  line-height: 6rem;
  width: 75rem;
  margin: 7rem auto 0;
  font-weight: 500;
}
.mainCoffee p {
  text-align: center;
  font-size: 2.2rem;
  width: 75rem;
  margin: 2rem auto 0;
  color: gray;
}
.mainCoffee__list {
  display: flex;
  justify-content: center;
  align-items: center;
  list-style: none;
  margin: 5rem auto 0;
  padding: 0;
}
.mainCoffee__listItem {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  margin: 0 3rem;
}
.mainCoffee__listItem img {
  width: 28rem;
}
.mainCoffee__listItem h3 {
  font-size: 2.5rem;
  margin: 2rem auto 0.5rem;
  color: black;
  font-weight: 500;
}
.mainCoffee__listItem p {
  width: 33rem;
  font-size: 1.8rem;
  margin: 0 auto;
  color: #666;
}
.mainCoffee button {
  color: white;
  background-color: #B38157;
  border: none;
  height: 5.5rem;
  width: 15rem;
  font-size: 1.6rem;
  letter-spacing: 0.2rem;
  font-family: "Roboto Condensed", sans-serif;
  margin: 7rem 0 10rem;
}

@media (max-width: 1150px) {
  .mainCoffee h1 {
    font-size: 4rem;
    width: 50rem;
    line-height: 5rem;
  }
  .mainCoffee p {
    font-size: 1.8rem;
    margin: 0 0 2rem;
    width: 50rem;
    max-width: 90%;
  }
  .mainCoffee__listItem img {
    width: 20rem;
  }
  .mainCoffee__listItem p {
    width: 26rem;
  }
}
@media (max-width: 950px) {
  .mainCoffee h1 {
    font-size: 3.5rem;
    line-height: 4rem;
    margin-bottom: 1rem;
  }
  .mainCoffee__list {
    flex-direction: column;
  }
  .mainCoffee__listItem {
    margin-bottom: 7rem;
  }
  .mainCoffee__listItem img {
    width: 35rem;
  }
  .mainCoffee__listItem h3 {
    font-size: 3rem;
  }
  .mainCoffee__listItem p {
    width: 40rem;
    font-size: 2rem;
    margin: 0;
  }
  .mainCoffee button {
    margin-top: 0;
  }
}
.coffeeShop {
  height: 72rem;
  display: flex;
  flex-direction: column;
  align-items: center;
  background: url("https://www.elegantthemes.com/layouts/wp-content/uploads/2017/12/section-bg-3.jpg");
  background-size: cover;
  background-position: center;
}
.coffeeShop__list {
  list-style: none;
  display: flex;
  justify-content: center;
  align-items: center;
  margin-bottom: 3.3rem;
  padding: 0;
}
.coffeeShop__listItem {
  margin: 0 6rem;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  color: #dca47d;
}
.coffeeShop__listItem img {
  width: 7.7rem;
}
.coffeeShop__listItem h5 {
  font-size: 2rem;
  margin: 1rem 0 0;
}
.coffeeShop h1 {
  font-size: 5rem;
  margin: 15rem auto 2rem;
  color: #fff;
  font-weight: 500;
}
.coffeeShop p {
  width: 60rem;
  margin: 0 auto;
  color: #fff;
  text-align: center;
  font-size: 1.8rem;
  line-height: 4rem;
}
.coffeeShop button {
  border: none;
  background-color: #B38157;
  color: white;
  height: 5.5rem;
  width: 15rem;
  font-size: 1.6rem;
  letter-spacing: 0.2rem;
  font-family: "Roboto Condensed", sans-serif;
  margin: 3rem auto 0;
}
.coffeeShop button:hover {
  cursor: pointer;
}

@media (max-width: 950px) {
  .coffeeShop {
    height: auto;
  }
  .coffeeShop h1 {
    margin: 10rem 0 4rem;
    width: 35rem;
    text-align: center;
    line-height: 5.5rem;
  }
  .coffeeShop__list {
    flex-direction: column;
  }
  .coffeeShop__listItem {
    margin: 0 0 5rem;
  }
  .coffeeShop__listItem:last-child {
    margin-bottom: 0;
  }
  .coffeeShop p {
    margin-top: 0;
    max-width: 85%;
  }
  .coffeeShop button {
    margin: 4rem 0 11rem;
  }
}
.freshBeans {
  display: flex;
  height: auto;
}
.freshBeans__info {
  flex: 1;
  display: flex;
  justify-content: center;
  margin-top: 10rem;
}
.freshBeans__info h1 {
  font-size: 5rem;
  margin: 0;
  font-weight: 500;
}
.freshBeans__info p {
  font-size: 1.8rem;
  color: #666;
  margin: 0;
  line-height: 3.3rem;
}
.freshBeans__info button {
  border: none;
  background-color: #B38157;
  color: white;
  margin-top: 4rem;
  margin-bottom: 10rem;
  height: 5.5rem;
  width: 15rem;
  font-size: 1.6rem;
  letter-spacing: 0.2rem;
  font-family: "Roboto Condensed", sans-serif;
}
.freshBeans__info--container {
  width: 44rem;
}
.freshBeans__image {
  flex: 1;
}
.freshBeans__image img {
  width: 100%;
  height: 100%;
}

@media (max-width: 950px) {
  .freshBeans {
    flex-direction: column;
  }
  .freshBeans__image {
    display: none;
  }
  .freshBeans__info--container {
    width: 80%;
  }
}
.greatCoffee {
  height: 50rem;
  display: flex;
  align-items: center;
  justify-content: flex-end;
  background: url("https://www.elegantthemes.com/layouts/wp-content/uploads/2017/12/section-bg-10.jpg");
  background-size: cover;
  background-position: 50%;
}
.greatCoffee__container {
  width: 55rem;
  margin-right: 12rem;
}
.greatCoffee__container h1 {
  font-size: 5rem;
  margin: 1rem 0 0;
  font-weight: 500;
}
.greatCoffee__container p {
  font-size: 1.8rem;
  color: #666;
  margin: 0;
}
.greatCoffee__container button {
  border: none;
  background-color: #B38157;
  color: white;
  margin-top: 4rem;
  height: 5.5rem;
  width: 15rem;
  font-size: 1.6rem;
  letter-spacing: 0.2rem;
  font-family: "Roboto Condensed", sans-serif;
}

@media (max-width: 1250px) {
  .greatCoffee__container {
    margin-right: 5rem;
    width: 45rem;
  }
}
@media (max-width: 950px) {
  .greatCoffee__container {
    width: 80%;
  }
}
.mainpageBlog {
  background-color: #f8f8f8;
  padding: 0.1rem;
  display: flex;
  flex-direction: column;
  align-items: center;
}
.mainpageBlog h1 {
  font-size: 5rem;
  margin: 8.8rem auto 0.5rem;
}
.mainpageBlog .para {
  font-size: 2rem;
  margin: 0rem;
  color: #666;
  width: 66rem;
  text-align: center;
}
.mainpageBlog__list {
  list-style: none;
  display: flex;
  justify-content: center;
  align-items: center;
  margin-top: 7rem;
  padding: 0;
}
.mainpageBlog__listItem {
  width: 35rem;
  background-color: white;
  margin: 0 2rem;
}
.mainpageBlog__listItem img {
  width: 100%;
}
.mainpageBlog__listItem h3 {
  font-size: 1.8rem;
  margin: 2rem 0 0.5rem 1.5rem;
}
.mainpageBlog__listItem span {
  margin: 0 0 0 1.5rem;
  font-size: 1.4rem;
  color: gray;
}
.mainpageBlog__listItem p {
  margin-left: 1.5rem;
  width: 30rem;
  font-size: 1.6rem;
  margin-bottom: 3rem;
  color: #666;
}
.mainpageBlog button {
  border: none;
  background-color: #B38157;
  color: white;
  height: 5.5rem;
  width: 15rem;
  font-size: 1.6rem;
  letter-spacing: 0.2rem;
  font-family: "Roboto Condensed", sans-serif;
  margin: 3rem auto 11rem;
}

.story {
  background-color: #1d140b;
  color: white;
  padding: 0.1rem;
  text-align: center;
  height: 50rem;
}
.story h1 {
  font-size: 5rem;
  margin: 11rem auto 1rem;
  font-weight: 500;
}
.story p {
  font-size: 2.2rem;
  width: 75rem;
  margin: 0 auto;
  line-height: 4rem;
}

@media (max-width: 950px) {
  .story {
    height: auto;
  }
  .story h1 {
    margin-bottom: 0;
  }
  .story p {
    max-width: 85%;
    margin-bottom: 10rem;
  }
}
.menuHeader {
  height: 80vh;
  background: url("https://www.elegantthemes.com/layouts/wp-content/uploads/2017/12/section-bg-8-1.jpg");
  background-size: cover;
  background-position: center;
  padding: 0.1rem;
}

.menuHeading {
  margin-top: 25rem;
}
.menuHeading h1 {
  font-size: 9rem;
  color: #333;
  text-align: center;
  margin: 0;
  font-weight: 500;
}
.menuHeading p {
  font-size: 2rem;
  width: 70rem;
  margin: -2rem auto 0;
  text-align: center;
  color: #666;
}

.coffeeMenu {
  display: flex;
  flex-direction: column;
  align-items: center;
  background-color: #272830;
}
.coffeeMenu h1 {
  font-size: 5rem;
  color: #fff;
  margin: 12rem auto 4rem;
  font-weight: 500;
}

.coffee__list {
  display: flex;
  justify-content: center;
  align-items: center;
  flex-wrap: wrap;
  width: 90%;
  max-width: 120rem;
  padding: 0;
}

.coffee__listItem {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  text-align: center;
  width: 35rem;
  margin: 0 2rem 10rem;
}
.coffee__listItem img {
  width: 25rem;
}
.coffee__listItem h3 {
  color: #fff;
  font-size: 2.5rem;
  font-weight: 500;
  margin: 1.7rem 0 1rem;
}
.coffee__listItem p {
  color: #fff;
  font-size: 1.8rem;
  margin-bottom: 1.5rem;
}
.coffee__listItem h5 {
  font-size: 2.5rem;
  color: #B38157;
  margin: 0;
}

.food__header {
  background: url("https://www.elegantthemes.com/layouts/wp-content/uploads/2017/12/section-bg-13.jpg");
  background-size: cover;
  background-position: center;
  padding: 0.1rem;
  height: 55rem;
  text-align: center;
}
.food__header h1 {
  font-size: 5rem;
  color: #333;
  margin: 12rem auto 4rem;
  font-weight: 500;
}
.food__header p {
  width: 75rem;
  margin: -2rem auto 0;
  font-size: 2rem;
  color: #666;
}

.pastries {
  display: flex;
  flex-direction: column;
  align-items: center;
  background-color: #272830;
}
.pastries h1 {
  font-size: 5rem;
  color: #fff;
  margin: 10rem auto 4rem;
  font-weight: 500;
}
.pastries__list {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  align-items: center;
  padding: 0;
  list-style: none;
  margin-bottom: 12rem;
}
.pastries__listItem {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  width: 35rem;
  text-align: center;
  margin: 0 2rem;
}
.pastries__listItem img {
  width: 25rem;
}
.pastries__listItem h3 {
  color: #fff;
  font-size: 2.5rem;
  font-weight: 500;
  margin: 2.2rem 0 1rem;
}
.pastries__listItem p {
  color: #fff;
  font-size: 1.8rem;
  margin-bottom: 1.5rem;
  margin-top: 0;
}
.pastries__listItem h5 {
  font-size: 2.5rem;
  color: #B38157;
  margin: 0;
}

.guideHeading {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  background: linear-gradient(rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0.7)), url("https://www.elegantthemes.com/layouts/wp-content/uploads/2017/12/background-2-1.jpg");
  background-size: cover;
  background-position: center;
  height: 100vh;
}
.guideHeading h1 {
  font-size: 9rem;
  color: #fff;
  text-align: center;
  margin: 0;
  font-weight: 500;
  margin: 5rem auto -1rem;
}
.guideHeading p {
  color: #fff;
  font-size: 2.2rem;
  text-align: center;
  margin: 0 auto 3rem;
}
.guideHeading button {
  border: none;
  background-color: #B38157;
  color: white;
  height: 5.5rem;
  width: 10rem;
  font-size: 1.6rem;
  letter-spacing: 0.2rem;
  font-family: "Roboto Condensed", sans-serif;
}

.instructions {
  width: 100rem;
  margin: 0 auto;
}
.instructions__list {
  display: flex;
  justify-content: space-between;
  margin: 15rem auto 5rem;
}
.instructions__intro h3 {
  color: #333;
  margin: 0;
  font-weight: 500;
  font-size: 2rem;
}
.instructions__intro p {
  width: 45rem;
  color: #666;
  font-size: 1.8rem;
  margin-top: 0.5rem;
}
.instructions__needs h3 {
  color: #333;
  margin: 0;
  font-weight: 500;
  font-size: 2rem;
}
.instructions__needs p {
  color: #666;
  font-size: 1.8rem;
  margin-top: 0.5rem;
}
.instructions__brewTime h3 {
  color: #333;
  margin: 0;
  font-weight: 500;
  font-size: 2rem;
}
.instructions__brewTime p {
  color: #666;
  font-size: 1.8rem;
  margin-top: 0.5rem;
}
.instructions__mainImage {
  width: 100%;
  margin-bottom: 15rem;
}
.instructions__mainImage img {
  width: 100%;
}
.instructions__step {
  border-top: 0.3rem solid #ddd;
}
.instructions__step h1 {
  margin: 4.5rem 0 0;
  color: #333;
  font-size: 5rem;
  font-weight: 500;
}
.instructions__step p {
  width: 60rem;
  font-size: 1.8rem;
  color: #666;
  margin: 0 0 4rem;
  line-height: 3.5rem;
}
.instructions__step img {
  width: 100%;
  margin-bottom: 15rem;
}
.instructions__step img:last-child {
  margin-bottom: 10rem;
}

.enjoy {
  background: linear-gradient(rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0.7)), url("https://www.elegantthemes.com/layouts/wp-content/uploads/2017/12/section-bg-9.jpg");
  background-size: cover;
  background-position: center;
  padding: 0.1rem;
  height: 50rem;
}
.enjoy h1 {
  font-size: 9rem;
  text-align: center;
  margin-top: 18rem;
  font-weight: 500;
  color: #fff;
}

.blogHeader {
  height: 50rem;
  background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url("https://www.elegantthemes.com/layouts/wp-content/uploads/2017/12/header-bg-2-2-2.jpg");
  background-size: cover;
  padding: 0.1rem;
}

.blogHeading {
  text-align: center;
  margin-top: 18rem;
}
.blogHeading h1 {
  color: #fff;
  font-size: 9rem;
  font-weight: 500;
  margin: 0;
}
.blogHeading p {
  color: #fff;
  font-size: 2rem;
  margin: -1.5rem auto 0;
  width: 66rem;
}

.blog {
  background-color: #f8f8f8;
  padding: 0.1rem;
}
.blog__list {
  list-style: none;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-wrap: wrap;
  margin: 10rem auto 5rem;
  max-width: 150rem;
}
.blog__listItem {
  width: 35rem;
  background-color: white;
  margin: 0 2rem 5rem;
}
.blog__listItem img {
  width: 100%;
}
.blog__listItem h3 {
  font-size: 1.8rem;
  margin: 2rem 0 0.5rem 1.5rem;
}
.blog__listItem span {
  margin: 0 0 0 1.5rem;
  font-size: 1.4rem;
  color: gray;
}
.blog__listItem p {
  margin-left: 1.5rem;
  width: 30rem;
  font-size: 1.6rem;
  margin-bottom: 3rem;
  color: #666;
}

.aboutHeader {
  height: 50rem;
  background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url("https://www.elegantthemes.com/layouts/wp-content/uploads/2017/12/header-bg-2-2-2.jpg");
  background-size: cover;
  padding: 0.1rem;
}

.aboutHeading {
  text-align: center;
  margin-top: 18rem;
}
.aboutHeading h1 {
  color: #fff;
  font-size: 9rem;
  font-weight: 500;
  margin: 0;
}
.aboutHeading p {
  font-size: 2rem;
  color: #fff;
  margin: -1.5rem auto 0;
  width: 66rem;
}

.aboutCoffee {
  display: flex;
  flex-direction: column;
  align-items: center;
}
.aboutCoffee h1 {
  font-size: 5rem;
  font-weight: 500;
  margin: 10rem 0 0;
}
.aboutCoffee p {
  font-size: 2rem;
  width: 66rem;
  text-align: center;
  color: #666;
  margin: 0;
}

.coffeeList {
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 0;
  list-style: none;
  margin: 6rem auto 10rem;
}
.coffeeListItem {
  display: flex;
  flex-direction: column;
  align-items: center;
  width: 32rem;
  margin: 0 1rem;
}
.coffeeListItem img {
  width: 7rem;
}
.coffeeListItem h3 {
  font-size: 2rem;
  font-weight: 500;
  margin: 2rem 0 1rem;
}
.coffeeListItem p {
  width: 90%;
  font-size: 1.8rem;
}

.aboutLocations {
  height: 75rem;
  background: url("https://www.elegantthemes.com/layouts/wp-content/uploads/2017/12/section-bg-4.jpg");
  background-size: cover;
  background-position: center;
  display: flex;
  justify-content: center;
  align-items: center;
}
.aboutLocations__info {
  background-color: #fff;
  width: 50rem;
  text-align: center;
  height: 50rem;
}
.aboutLocations__info h1 {
  font-size: 4rem;
  margin: 7rem auto 2rem;
  width: 80%;
  font-weight: 500;
  line-height: 5rem;
}
.aboutLocations__info p {
  width: 80%;
  font-size: 1.8rem;
  color: #666;
  margin: 2rem auto 4rem;
  line-height: 3.5rem;
}
.aboutLocations__info button {
  border: none;
  background-color: #dca47d;
  color: white;
  height: 5.5rem;
  width: 15rem;
  font-size: 1.6rem;
  letter-spacing: 0.2rem;
  font-family: "Roboto Condensed", sans-serif;
}
.aboutLocations__container {
  display: flex;
  flex-direction: column;
  align-items: flex-start;
  width: 50rem;
  height: 50rem;
  margin-left: 4rem;
}
.aboutLocations__image {
  width: 100%;
}
.aboutLocations__image img {
  width: 100%;
  height: 30rem;
}
.aboutLocations__count {
  display: flex;
  justify-content: space-between;
  align-items: center;
  background-color: #fff;
  width: 100%;
  height: 100%;
  margin-top: 3rem;
}
.aboutLocations__count h1 {
  font-size: 3rem;
  color: #333;
  margin: 0;
}
.aboutLocations__count h3 {
  color: #dca47d;
  font-size: 2rem;
  font-weight: 500;
  margin: 0;
}
.aboutLocations__count .varieties {
  text-align: center;
  margin-left: 5rem;
}
.aboutLocations__count .locations {
  text-align: center;
  margin-right: 5rem;
}

.aboutGallery {
  display: flex;
  flex-direction: column;
  align-items: center;
}
.aboutGallery h1 {
  font-size: 5rem;
  color: #333;
  font-weight: 500;
  margin: 10rem auto 1rem;
}
.aboutGallery p {
  font-size: 2rem;
  color: #888;
  margin: -1.5rem auto 0;
  width: 66rem;
  text-align: center;
}
.aboutGallery__list {
  display: flex;
  justify-content: center;
  align-items: flex-start;
  margin: 5rem 0 0 5rem;
  width: auto;
}
.aboutGallery__mainImage {
  width: 53.5rem;
}
.aboutGallery__mainImage img {
  width: 100%;
}
.aboutGallery__secondary {
  list-style: none;
  padding: 0;
  display: flex;
  flex-wrap: wrap;
  justify-content: flex-start;
  align-items: flex-start;
  margin: 0 0 7rem 0;
  width: 58.5rem;
}
.aboutGallery__secondaryItem {
  width: 25rem;
  margin: 0 0 3rem 3rem;
}
.aboutGallery__secondaryItem img {
  width: 100%;
}

.images {
  display: flex;
  width: 100%;
}
.images__image {
  flex: 1;
}
.images__image img {
  width: 100%;
}

.ourTeam {
  display: flex;
  flex-direction: column;
  align-items: center;
}
.ourTeam h1 {
  font-size: 5rem;
  font-weight: 500;
  margin: 10rem auto 0;
}
.ourTeam p {
  margin: 0;
  font-size: 1.8rem;
  line-height: 3.5rem;
  color: #888;
  width: 66rem;
  text-align: center;
}
.ourTeam__list {
  display: flex;
  justify-content: center;
  margin: 5rem auto 5rem;
  padding: 0;
  list-style: none;
}
.ourTeam__listItem {
  margin: 0 3rem;
  width: 33rem;
}
.ourTeam__listItem img {
  width: 100%;
}
.ourTeam__listItem h3 {
  font-size: 2.5rem;
  font-weight: 500;
  margin: 1rem 0 0;
}
.ourTeam__listItem h5 {
  color: #666;
  font-size: 1.8rem;
  margin: 0;
  font-weight: 300;
}
.ourTeam button {
  border: none;
  background-color: #dca47d;
  color: white;
  height: 5.5rem;
  width: 15rem;
  font-size: 1.6rem;
  letter-spacing: 0.2rem;
  font-family: "Roboto Condensed", sans-serif;
  margin-bottom: 7rem;
}

.contactHeader {
  background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url("https://www.elegantthemes.com/layouts/wp-content/uploads/2017/12/header-bg-2-2-2-2.jpg");
  background-size: cover;
  height: 50rem;
  padding: 0.1rem;
}

.contactHeading {
  margin-top: 18rem;
}
.contactHeading h1 {
  font-size: 9rem;
  color: #fff;
  text-align: center;
  margin: 0;
  font-weight: 500;
  margin: 5rem auto -1rem;
}
.contactHeading p {
  color: #fff;
  font-size: 2.2rem;
  text-align: center;
  margin: 0 auto 3rem;
  width: 75rem;
  text-align: center;
}

.contactInfo {
  display: flex;
  height: 50rem;
}
.contactInfo__form {
  flex: 1;
  height: 100%;
}
.contactInfo__newsletter {
  background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url("../../img/coffee-beans.png");
  background-size: cover;
  flex: 1;
  text-align: center;
  height: 100%;
}
.contactInfo__newsletter h1 {
  font-size: 4rem;
  font-weight: 500;
  margin: 7rem auto 0;
  color: #fff;
}
.contactInfo__newsletter p {
  font-size: 2rem;
  margin: 0 auto;
  width: 55rem;
  text-align: center;
  color: #eee;
}
.contactInfo__newsletter input {
  display: block;
  margin: 3rem auto 2rem;
  width: 56rem;
  height: 5rem;
  font-size: 1.8rem;
  text-indent: 2rem;
  border: none;
}
.contactInfo__newsletter button {
  display: block;
  margin: 0 auto;
  width: 56rem;
  height: 5.4rem;
  border: none;
  background-color: #dca47d;
  color: #fff;
  font-size: 1.6rem;
  letter-spacing: 0.2rem;
  font-family: "Roboto Condensed", sans-serif;
}
.contactInfo__newsletter button:hover {
  cursor: pointer;
}
.contactInfo__form form {
  width: 80%;
  margin: 7rem auto 0;
}
.contactInfo__form form .topRow {
  display: flex;
  width: 100%;
  justify-content: space-between;
}
.contactInfo__form form label {
  font-size: 4rem;
  margin: 0;
  font-weight: 500;
}
.contactInfo__form form input {
  width: 29rem;
  height: 5rem;
  font-size: 1.5rem;
  text-indent: 1.5rem;
  border: 0.1rem solid lightgray;
}
.contactInfo__form form textarea {
  display: block;
  width: 100%;
  padding: 0;
  margin-top: 2rem;
  text-indent: 1.5rem;
  font-size: 1.5rem;
  height: 14rem;
  padding-top: 1.5rem;
  border: 0.1rem solid lightgray;
}
.contactInfo__form form button {
  float: right;
  border: none;
  background-color: #dca47d;
  color: white;
  height: 5.5rem;
  width: 12rem;
  font-size: 1.6rem;
  letter-spacing: 0.2rem;
  font-family: "Roboto Condensed", sans-serif;
  margin-top: 2rem;
}

/*# sourceMappingURL=main.cs.map */
