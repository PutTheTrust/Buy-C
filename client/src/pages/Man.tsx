import React, { useEffect, useState } from "react";
import { Header, Loader } from "../components";
import ListShoes from "../components/ListShoes";
import axios from "axios";

const Man = () => {
  const [isLoading, setLoading] = useState(false);
  const [man, setMan] = useState<any>();
  useEffect(() => {
    const getKids = async () => {
      setLoading(true);
      try {
        const response = await axios.get(
          "https://localhost:7241/api/product/category/Man"
        );
        setMan(response.data);
        console.log(response.data);
      } catch (e) {
        console.log(e);
      } finally {
        setLoading(false);
      }
    };

    getKids();
  }, []);
  return (
    <div className="mx-4">
      <Header />

      {isLoading ? <Loader /> : <ListShoes data={man} />}
    </div>
  );
};

export default Man;
