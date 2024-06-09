/* src/utils/helper.js */
// Icon Package Block
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import {
  faSpinner,
  faCircleCheck,
  faCircleXmark,
  faCirclePause,
} from '@fortawesome/free-solid-svg-icons';

export const getStatusIcon = (status) => {
  switch (status) {
    case 'loading':
      return <FontAwesomeIcon icon={faSpinner} spinPulse />;
    case 'valid':
      return <FontAwesomeIcon icon={faCircleCheck} />;
    case 'invalid':
      return <FontAwesomeIcon icon={faCircleXmark} />;
    case 'ready':
    default:
      return <FontAwesomeIcon icon={faCirclePause} />;
  }
};

export const validateEmail = (email) => {
  const regex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
  return regex.test(email);
};
