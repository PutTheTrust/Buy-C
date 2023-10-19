import React, { useState } from "react";

import logo from "../assets/images/logo.svg";
import search from "../assets/images/icon-search.svg";
import heart from "../assets/images/icon-heart.svg";
import menu from "../assets/images/icon-menu.svg";
import bag from "../assets/images/icon-bag.svg";
import MobileNav from "./MobileNav";

const Header = () => {
  const [isOpen, setIsOpen] = useState(true);
  return (
    <>
      <div className="flex justify-between items-center">
        <img src={logo} alt="logo" />

        <ul className="hidden md:flex md:gap-6 md:font-medium text-white">
          <li>
            <a href="/">Man</a>
          </li>
          <li>
            <a href="/">Woman</a>
          </li>
          <li>
            <a href="/">Kids</a>
          </li>
          <li>
            <a href="/">Accessories</a>
          </li>
          <li>
            <a href="/">New In</a>
          </li>
        </ul>

        <div className="hidden md:flex md:gap-2 ">
          <button>
            <img src={search} alt="logo" />
          </button>

          <button>
            <img src={heart} alt="Favourites" />
          </button>

          <button className="bg-black w-10 h-10 flex justify-center items-center rounded-full">
            <img src={bag} alt="Cart" />
          </button>
        </div>

        <div className="flex gap-2 md:hidden">
          <button>
            <img src={search} alt="search" />
          </button>

          <button>
            <img src={heart} alt="heart" />
          </button>

          <button onClick={() => setIsOpen(true)}>
            <img src={menu} alt="menu" />
          </button>
        </div>
      </div>

      <div className="bg-gray-100 h-[0.5px] mt-4" />
      <MobileNav setIsOpen={setIsOpen} isOpen={isOpen} />
    </>
  );
};

export default Header;
