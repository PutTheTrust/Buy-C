import { Dispatch, SetStateAction } from "react";

import close from "../assets/images/icon-close.svg";
import { Link } from "react-router-dom";

interface MobileNavProps {
  setIsOpen: Dispatch<SetStateAction<boolean>>;
  isOpen: boolean;
}

const MobileNav = ({ setIsOpen, isOpen }: MobileNavProps) => {
  return (
    <div
      className={
        isOpen
          ? "bg-white fixed z-50 top-0 right-0 w-[75%] h-screen transition-all duration-300"
          : "bg-white fixed z-50 top-0 right-0 w-[0%] h-screen transition-all duration-300"
      }
    >
      <button
        className="flex float-right mr-4 mt-4"
        onClick={() => setIsOpen(false)}
      >
        <img src={close} alt="close" className="w-10 h-10" />
      </button>
      <ul className="mt-12 space-y-5 ml-6">
        <li>
          <Link to="/man">Man</Link>
        </li>
        <li>
          <Link to="/woman">Woman</Link>
        </li>
        <li>
          <Link to="/kids">Kids</Link>
        </li>
        <li>
          <Link to="/accessories">Accessories</Link>
        </li>
        {/* <li>
          <a href="/man">New in</a>
        </li> */}
      </ul>
    </div>
  );
};

export default MobileNav;
