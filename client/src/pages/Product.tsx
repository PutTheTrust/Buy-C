import React, { useEffect, useState } from "react";
import { Header, Loader } from "../components";
import Button from "../components/Button";
import axios from "axios";
import { useParams } from "react-router-dom";

const Product = () => {
  const [product, setProduct] = useState<any>();
  const [isLoading, setLoading] = useState(false);
  let { id } = useParams();
  useEffect(() => {
    setLoading(true);
    const fetchProduct = async () => {
      try {
        const result = await axios.get(
          `https://localhost:7241/api/product/${id}`
        );
        setProduct(result.data);
        // console.log();
      } catch (e) {
      } finally {
        setLoading(false);
      }
    };

    fetchProduct();
  }, []);
  return (
    <div className="mx-4 md:max-w-[1196px] md:mx-auto ">
      <Header />
      {/* REPLACE WITH SHIMMER EFFECT */}
      {isLoading ? (
        <Loader />
      ) : (
        <div className="md:flex md:justify-center md:gap-[5%] mt-4 ">
          <img className="md:w-2/5" src={product?.image} alt="shoe" />
          <div className="md:w-2/5 md:flex md:flex-col md:justify-center">
            <p className="text-2xl font-semibold mt-4">{product?.name}</p>
            <p className="text-xl font-bold mt-4">R{product?.price}</p>

            <div className="h-9 bg-slate-300 mt-4" />

            <div className="flex flex-col gap-4 mt-4">
              <Button text="Add to cart" isOutline={false} />
              <Button text="Favourite" isOutline={true} />
            </div>
          </div>
        </div>
      )}
    </div>
  );
};

export default Product;
