import { Header, HomeTitle } from "../components";

// import shoe from "../assets/images/DURAMO SL SHOES.avif";
import item from "../assets/images/grailify-4y_zTA_M35k-unsplash.jpg";
import { useEffect, useState } from "react";
import axios from "axios";
import FeaturedShoes from "../components/FeaturedShoes";

interface Products {
  id: String;
  image: String;
  name: String;
  price: String;
}

const Home = () => {
  const [products, setProducts] = useState<Products>();
  const [newProducts, setNewProducts] = useState<Products>();
  const [isLoading, setLoading] = useState<boolean>();

  useEffect(() => {
    const fetchProducts = async () => {
      setLoading(true);
      try {
        const response = await axios.get("https://localhost:7241/api/product/");
        setProducts(response.data);
      } catch (e) {
        console.log("FETCH PRODUCTS _> ", e);
      }
    };

    fetchProducts();
    setLoading(false);
  }, []);
  return (
    <>
      <div className="mx-4 mt-4 md:max-w-[1196px] md:mx-auto ">
        <div className="h-[560px] md:h-screen overflow-auto">
          <Header />
          <div className="mt-[104px] md:mt-[20%] text-gray-800 font-bold md:w-[345px]">
            <h1 className="text-2xl md:text-3xl">
              Adidas sneaker X.Z.E Wild Weather Rock
            </h1>
            <h2 className="text-2xl md:text-3xl my-4">R1520.58</h2>
            <button className="bg-gray-100 h-[42px] px-4 rounded text-black">
              View Product
            </button>
          </div>

          <img
            className="absolute inset-0 -z-10 w-full h-[560px] md:h-screen  object-cover"
            src={item}
            alt="carousel"
          />
        </div>
        <HomeTitle title="Our Products" nav="man" />

        {isLoading ? (
          <p>Loading...</p>
        ) : (
          products !== null && <FeaturedShoes product={products} />
        )}

        <HomeTitle title="New Arrivals" nav="man" />

        {/* {isLoading ? (
          <p>Loading...</p>
        ) : (
          <FeaturedShoes product={newProducts} />
        )} */}
      </div>
    </>
  );
};

export default Home;
