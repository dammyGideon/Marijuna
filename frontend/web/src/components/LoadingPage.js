// Custom Component Block
import { logoIcon } from '../utils/constant';
import { logoText } from '../utils/constant/index';

const LoadingPage = () => {
  return (
    <>
      <div className="loader">
        <img src={logoIcon} alt="HerbzHub Logo" width={150} />;
        <img src={logoText} alt="HerbzHub Text" width={150} />
      </div>
    </>
  );
};

export default LoadingPage;
