# Baigiamasis Darbas

### Web application used for testing:

[Baldai1](www.baldai1.lt)



### Prerequisites

[Baldai1](www.baldai1.lt) webapge should be opened for all test scenarious.

### Test scenarious and test cases

1. Search

   1.1. Search functionality

       1.1.1. Place text cursor in Search textbox;
       1.1.2. Enter search word "LOVA";
       1.2.3. Click enter for the results;
       1.2.4. Results "LOVA" dispayed;

2. Shopping cart functionality

    2.1. Add item to cart 

        2.1.1. In homepage scroll to "MINKÐTI BALDAI";
        2.1.2. Click on "Minkðtas kampas Delaware 100";
        2.1.3. In new window press "Á krepðelá";
        2.1.4. CLose pop-up;
        2.1.5. Open shopping cart to see if item added;

3. Chekout functionality

    3.1. Email error message at the chekout 

        3.1.1. Put item no into searchbox "467169";
        3.1.2. Run search;
        3.1.3. Open found item;
        3.1.4. Add item using button "Á krepðelá"
        3.1.5. Press "Atsiskaityti";
        3.1.6. Enter Vardas "TEST";
        3.1.7. Enter Pavardë "TEST";
        3.1.8. Enter Telefono numeris "862222222";
        3.1.9. Enter El. Paðto adresas "TEST";
        3.1.10. Not possible to proceed with the purchase;

    3.2. Proceed with the payment after entering valid customer data
    
        3.2.1. Add item to shopping cart;
        3.2.2. Press "Atsiskaityti";
        3.2.3. Enter Vardas "TEST";
        3.2.4. Enter Pavardë "TEST";
        3.2.5. Enter Telefono numeris "862222222";
        3.2.6. Enter El. Paðto adresas "TEST@gmail.com";
        3.2.7. Possible proceed with the purchase;

    3.3. Discount code functionality

        3.3.1. Add item to shopping cart;
        3.2.2. Press "Atsiskaityti";
        3.2.3. At the chekout enter code BLACK50 to discount box;
        3.2.4. Discount applied;

    


