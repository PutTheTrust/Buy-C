import { Dispatch, SetStateAction } from "react";

import close from "../assets/images/icon-close.svg";

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
          <a href="/man">Man</a>
        </li>
        <li>
          <a href="/man">Woman</a>
        </li>
        <li>
          <a href="/man">Kids</a>
        </li>
        <li>
          <a href="/man">Accessories</a>
        </li>
        <li>
          <a href="/man">New in</a>
        </li>
      </ul>
    </div>
  );
};

export default MobileNav;
