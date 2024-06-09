// Package Block
import axios from 'axios';

// Get URL
import { GET_ALL_STATES_URL } from '../constant';

export function getAllStates() {
  return axios.get(GET_ALL_STATES_URL);
}
