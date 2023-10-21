import React, { useEffect, useState } from "react";
import { Header, Loader } from "../components";
import ListShoes from "../components/ListShoes";
import axios from "axios";

const Woman = () => {
  const [isLoading, setLoading] = useState(false);
  const [woman, setWoman] = useState<any>();
  useEffect(() => {
    const getWoman = async () => {
      setLoading(true);
      try {
        const response = await axios.get(
          "https://localhost:7241/api/product/category/Woman"
        );
        setWoman(response.data);
        console.log(response.data);
      } catch (e) {
        console.log(e);
      } finally {
        setLoading(false);
      }
    };

    getWoman();
  }, []);
  return (
    <div className="mx-4">
      <Header />

      {isLoading ? <Loader /> : <ListShoes data={woman} />}
    </div>
  );
};

export default Woman;
