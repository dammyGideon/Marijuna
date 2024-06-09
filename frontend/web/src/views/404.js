// Package Block
import { Link } from 'react-router-dom';

// Custom Component Block
import { logoIcon } from '../utils/constant';
import { logoText } from '../utils/constant/index';

export default function PageNotFound() {
  return (
    <>
      <div className="loader">
        <img src={logoIcon} alt="HerbzHub Logo" width={150} />
        <img src={logoText} alt="HerbzHub Text" width={150} />
        <p className="not-found-content">Ooooops! Page not found</p>
        <Link to="/">Back Home</Link>
      </div>
    </>
  );
}
