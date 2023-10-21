import { Routes, Route } from "react-router-dom";

import { Accessories, Home, Kids, Man, Product } from "./pages";
import Woman from "./pages/Woman";

function App() {
  return (
    <div className="md:max-w-[1196px] md:mx-auto ">
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/product/:id" element={<Product />} />
        <Route path="/man" element={<Man />} />
        <Route path="/woman" element={<Woman />} />
        <Route path="/kids" element={<Kids />} />
        <Route path="/accessories" element={<Accessories />} />
      </Routes>
    </div>
  );
}

export default App;
