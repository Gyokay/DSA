'use strict'

function binarySearch (arr, leftmostIndex, rightmostIndex, x) {
	if (leftmostIndex > rightmostIndex) {
		return -1
	} else {
		let midIndex = leftmostIndex + (rightmostIndex - leftmostIndex) / 2

		if (arr[midIndex] === x) {
			return midIndex
		} else if (arr[midIndex] > x) {
			return binarySearch(arr, leftmostIndex, midInex - 1, x)
		} else {
			return binarySearch(arr, midIndex + 1, rightmostIndex, x)
		}
	}
}

