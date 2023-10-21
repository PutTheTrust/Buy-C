import React, { useEffect, useState } from "react";
import { Header, Loader } from "../components";
import ListShoes from "../components/ListShoes";
import axios from "axios";

const Kids = () => {
  const [isLoading, setLoading] = useState(false);
  const [Kids, setKids] = useState<any>();
  useEffect(() => {
    const getKids = async () => {
      setLoading(true);
      try {
        const response = await axios.get(
          "https://localhost:7241/api/product/category/Kids"
        );
        setKids(response.data);
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

      {isLoading ? <Loader /> : <ListShoes data={Kids} />}
    </div>
  );
};

export default Kids;
