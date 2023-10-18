import React from "react";
import Card from "./Card";

// interface Data {
//   id: String;
//   image: String;
//   name: String;
//   price: String;
// }

// interface FeaturedShoes {
//     product:

// }

const FeaturedShoes = ({ product }: any) => {
  console.log(product);
  return (
    <div className="mt-7 md:flex md:gap-4">
      {product.map((prod: any) => (
        <Card
          key={prod.id}
          image={prod.image}
          name={prod.name}
          price={prod.price}
        />
      ))}
    </div>
  );
};

export default FeaturedShoes;
