import React, { useEffect, useState } from "react";
import { Header, Loader } from "../components";
import ListShoes from "../components/ListShoes";
import axios from "axios";

const Accessories = () => {
  const [isLoading, setLoading] = useState(false);
  const [accessories, setAccessories] = useState<any>();
  useEffect(() => {
    const getAccessories = async () => {
      setLoading(true);
      try {
        const response = await axios.get(
          "https://localhost:7241/api/product/category/Accessories"
        );
        setAccessories(response.data);
        console.log(response.data);
      } catch (e) {
        console.log(e);
      } finally {
        setLoading(false);
      }
    };

    getAccessories();
  }, []);
  return (
    <div className="mx-4">
      <Header />

      {isLoading ? <Loader /> : <ListShoes data={accessories} />}
    </div>
  );
};

export default Accessories;
