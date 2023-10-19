import { useEffect, useState } from "react";
import axios from "axios";

import FeaturedShoes from "../components/FeaturedShoes";
import { Header, HomeTitle, Loader } from "../components";
import Footer from "../components/Footer";

import item from "../assets/images/Hero.png";
import { url } from "inspector";

interface Products {
  id: String;
  image: String;
  name: String;
  price: String;
}

const Home = () => {
  const [products, setProducts] = useState([]);
  const [newProducts, setNewProducts] = useState([]);
  const [isLoading, setLoading] = useState<boolean>();

  useEffect(() => {
    setLoading(true);

    const fetchProducts = axios.get(
      "https://localhost:7241/api/product?isFeatured=true"
    );
    const fetchNew = axios.get("https://localhost:7241/api/product?isNew=true");

    Promise.all([fetchProducts, fetchNew])
      .then((responses) => {
        const [productsResponse, ordersResponse] = responses;
        setProducts(productsResponse.data);
        setNewProducts(ordersResponse.data);
      })
      .catch((error) => {
        console.log("Error fetching data: ", error);
      })
      .finally(() => {
        setLoading(false);
      });
  }, []);

  if (!isLoading) {
    console.log(products);
  }
  return (
    <>
      <div className="mx-4 mt-4 md:max-w-[1196px] md:mx-auto ">
        <Header />
        <div className="hero h-[360px] md:h-[560px] flex flex-col justify-center items-center text-center rounded-2xl mb-4">
          <div className=" text-gray-200 font-bold md:max-w-[450px]">
            <h1 className="text-2xl md:text-4xl">
              Adidas sneaker X.Z.E Wild Weather Rock
            </h1>
            <h2 className="text-2xl md:text-3xl my-4">R1520.58</h2>
            <button className="bg-gray-100 h-[42px] px-4 rounded text-black">
              View Product
            </button>
          </div>
        </div>

        <HomeTitle title="Our Products" nav="man" />

        {isLoading ? (
          <Loader />
        ) : (
          products !== null && <FeaturedShoes product={products} />
          // <p>Data</p>
        )}

        <HomeTitle title="New Arrivals" nav="man" />

        {/* {isLoading ? (
          <p>Loading...</p>
        ) : (
          <FeaturedShoes product={newProducts} />
        )} */}

        {isLoading ? (
          <Loader />
        ) : (
          newProducts !== null && <FeaturedShoes product={newProducts} />
          // <p>Data</p>
        )}
      </div>
      <Footer />
    </>
  );
};

export default Home;
