import { Link } from "react-router-dom";
import bag from "../assets/images/icon-bag.svg";

interface CardProps {
  image: string;
  name: string;
  price: string;
  id: number;
}

const Card = ({ image, name, price, id }: CardProps) => {
  return (
    <div className="rounded-[15px] overflow-hidden max-w-[345px] flex-shrink-0 my-3">
      <Link to={`product/${id}`}>
        <img className="rounded-[15px]" src={image} alt={name} />
      </Link>
      <div className="flex justify-between items-center mt-5">
        <div className="font-semibold">
          <h2>{name}</h2>
          <h3>R{price}</h3>
        </div>

        <button className="bg-black w-10 h-10 flex justify-center items-center rounded-full">
          <img src={bag} alt="Cart" />
        </button>
      </div>
    </div>
  );
};

export default Card;
