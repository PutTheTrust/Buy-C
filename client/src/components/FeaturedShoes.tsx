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
    // <div className="md:flex flex-1 overflow-auto">
    <div className="mt-7 flex justify-between gap-4 w-full overflow-x-auto prod">
      {product.map((prod: any) => (
        <Card
          key={prod.id}
          image={prod.image}
          name={prod.name}
          price={prod.price}
          id={prod.id}
        />
      ))}
    </div>
    // </div>
  );
};

export default FeaturedShoes;
