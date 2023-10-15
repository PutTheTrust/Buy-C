import React from "react";

interface HomeTitleProps {
  title: String;
  nav: String;
}

const HomeTitle = ({ title, nav }: HomeTitleProps) => {
  return (
    <div className="flex justify-between items-center uppercase ">
      <h2 className="text-2xl font-bold">{title}</h2>
      <a href={`/${nav}`} className="text-sm">
        View All
      </a>
    </div>
  );
};

export default HomeTitle;
