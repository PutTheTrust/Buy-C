import Card from "./Card";

const ListShoes = ({ data }: any) => {
  return (
    <div className="md:grid grid-cols-2 lg:grid-cols-3">
      {data &&
        data.map((prod: any) => (
          <Card
            image={prod.image}
            name={prod.name}
            price={prod.price}
            id={prod.id}
          />
        ))}
    </div>
  );
};

export default ListShoes;
