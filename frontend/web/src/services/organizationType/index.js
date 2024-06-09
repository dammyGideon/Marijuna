// Package Block
import axios from 'axios';

// Constant
import { GET_ORGANIZATION_TYPE_URL } from '../constant';

export function getOrganizationType() {
  return axios.get(GET_ORGANIZATION_TYPE_URL).then(response => response.data);
}
